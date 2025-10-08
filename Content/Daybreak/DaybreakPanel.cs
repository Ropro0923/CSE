using System.Collections.Generic;
using System.Text;
using Daybreak.Common.Features.ModPanel;
using Daybreak.Common.Rendering;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent;
using Terraria.GameContent.UI.Elements;
using Terraria.UI;
using Terraria.Utilities;

namespace CSE.Content.Daybreak
{
    [Autoload(Side = ModSide.Client)]
    [ExtendsFromMod(ModCompatibility.Daybreak.Name)]
    [JITWhenModsEnabled(ModCompatibility.Daybreak.Name)]
    public class CustomModPanel : ModPanelStyle
    {
        public class AnimatedModName(string text, float textScale = 1, bool large = false) : UIText(text, textScale, large)
        {
            private readonly string originalText = text;
            protected override void DrawSelf(SpriteBatch spriteBatch)
            {
                var formattedText = GetAnimatedText(originalText, Main.GlobalTimeWrappedHourly);
                SetText(formattedText);
                base.DrawSelf(spriteBatch);
            }
            private static string GetAnimatedText(string text, float time)
            {
                var sb = new StringBuilder(text.Length * 12);
                var startColor = new Color(97, 180, 155);
                var endColor = new Color(90, 151, 133);
                for (var i = 0; i < text.Length; i++)
                {
                    float wave = Sin(time * 1.5f + i * 0.3f) * 0.5f + 0.5f;
                    var color = Color.Lerp(startColor, endColor, wave);
                    color.A = 255;
                    sb.Append($"[c/{color.Hex3()}:{text[i]}]");
                }
                return sb.ToString();
            }
        }
        public class AnimatedIcon(Texture2D texture) : UIImage(texture)
        {
            private static readonly Color StartGradientColor = new(20, 81, 63);
            private static readonly Color EndGradientColor = new(27, 110, 85);
            private static readonly Color ModIconColor = new(255, 255, 200);
            private const float BaseScale = 0.8f;
            private const float HoverScaleBonus = 0.2f;
            private const float PulseAmplitude = 0.1f;
            private const float PulseFrequency = 4f;
            private const float RotationAmplitude = 0.15f;
            private const float RotationFrequency = 2f;
            private const float ModIconScaleMultiplier = 1.0f;
            private const float ParticleSpawnInterval = 0.1f;
            private const float ParticleDistance = 40f;
            private const float ParticleDistanceVariation = 30f;
            private const float ParticleBaseLife = 2f;
            private const float ParticleLifeVariation = 2f;
            private const float ParticleBaseScale = 0.1125f;
            private const float ParticleScaleVariation = 0.15f;
            private const float ParticleGravityStrength = 30f;
            private const float ParticleVelocityDamping = 0.95f;
            private float hoverIntensity;
            private static readonly UnifiedRandom random = new();
            private readonly List<MagicParticle> particles = [];
            private float particleTimer;
            private class MagicParticle
            {
                public Vector2 Position;
                public Vector2 Velocity;
                public float Life;
                public float MaxLife;
                public float Scale;
                public Color Color;
                public float Rotation;
                public float RotationSpeed;
                public bool UseModIcon;
            }
            protected override void DrawSelf(SpriteBatch spriteBatch)
            {
                var dims = GetDimensions().ToRectangle();
                Vector2 center = dims.Center();
                var ModIcon = ModContent.Request<Texture2D>("CSE/Assets/Daybreak/ModIcon").Value;
                bool panelHovered = Parent?.IsMouseHovering ?? false;
                hoverIntensity = Lerp(hoverIntensity, panelHovered ? 1f : 0f, 0.15f);
                float scale = BaseScale + hoverIntensity * HoverScaleBonus + Sin(Main.GlobalTimeWrappedHourly / PulseFrequency) * PulseAmplitude;
                float rotation = Sin(Main.GlobalTimeWrappedHourly / RotationFrequency) * RotationAmplitude;
                UpdateParticles(center, hoverIntensity);
                float ModIconScale = scale * ModIconScaleMultiplier;
                spriteBatch.Draw(
                    ModIcon,
                    center,
                    ModIcon.Frame(),
                    ModIconColor,
                    rotation,
                    ModIcon.Size() / 2,
                    ModIconScale * 1.3f,
                    SpriteEffects.None,
                    0f
                );
            }
            private void UpdateParticles(Vector2 center, float hoverIntensity)
            {
                particleTimer += 1f / 60f;
                if (particleTimer > ParticleSpawnInterval)
                {
                    particleTimer = 0f;
                    int spawnCount = (int)((2 + hoverIntensity * 4) / 3f);
                    for (int i = 0; i < spawnCount; i++)
                    {
                        float angle = random.NextFloat(TwoPi);
                        float distance = ParticleDistance + random.NextFloat(ParticleDistanceVariation);
                        Vector2 spawnPos = center + new Vector2(Cos(angle), Sin(angle)) * distance;  
                        float life = ParticleBaseLife + random.NextFloat(ParticleLifeVariation);
                        particles.Add(new MagicParticle
                        {
                            Position = spawnPos,
                            Velocity = new Vector2(random.NextFloat(-0.5f, 0.5f), random.NextFloat(-0.5f, 0.5f)) * 20f,
                            Life = life,
                            MaxLife = life,
                            Scale = ParticleBaseScale + random.NextFloat(ParticleScaleVariation),
                            Color = Color.Lerp(StartGradientColor, EndGradientColor, random.NextFloat()),
                            Rotation = random.NextFloat(TwoPi),
                            RotationSpeed = random.NextFloat(-1f, 1f) * 2f,
                            UseModIcon = random.NextFloat() < 0.5f
                        });
                    }
                }
                for (int i = particles.Count - 1; i >= 0; i--)
                {
                    var particle = particles[i];
                    particle.Life -= 1f / 60f;
                    particle.Position += particle.Velocity * (1f / 60f);
                    particle.Rotation += particle.RotationSpeed * (1f / 60f);
                    Vector2 toCenter = center - particle.Position;
                    particle.Velocity += toCenter.SafeNormalize(Vector2.Zero) * ParticleGravityStrength * (1f / 60f);
                    particle.Velocity *= ParticleVelocityDamping;
                    if (particle.Life <= 0)
                    {
                        particles.RemoveAt(i);
                    }
                }
            }
        }
        private static float panelHoverIntensity;
        private static Effect panelShader;
        private const int BorderThickness = 2;
        public override void Load()
        {
            base.Load();
            if (Main.netMode != NetmodeID.Server && ModLoader.HasMod("Daybreak"))
            {
                panelShader = ModContent.Request<Effect>("CSE/Assets/Daybreak/ModPanelGradient", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value;
            }
        }
        public override void Unload()
        {
            panelShader = null;
            base.Unload();
        }
        public override UIImage ModifyModIcon(UIPanel element, UIImage modIcon, ref int modIconAdjust) => new AnimatedIcon(TextureAssets.MagicPixel.Value)
        {
            Left = modIcon.Left,
            Top = modIcon.Top,
            Width = modIcon.Width,
            Height = modIcon.Height,
        };

        public override UIText ModifyModName(UIPanel element, UIText modName) => new AnimatedModName(modName.Text)
        {
            Left = modName.Left,
            Top = modName.Top,
        };
        public override bool PreDrawPanel(UIPanel element, SpriteBatch sb, ref bool drawDivider)
        {
            var dims = element.GetDimensions();
            panelHoverIntensity = Lerp(panelHoverIntensity, element.IsMouseHovering ? 0.6f : 0f, 0.15f);
            var panelRect = new Rectangle((int)dims.X, (int)dims.Y, (int)dims.Width, (int)dims.Height);
            sb.End(out var ss);
            sb.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend, SamplerState.PointClamp, DepthStencilState.None, ss.RasterizerState, panelShader, Main.UIScaleMatrix);
            panelShader.Parameters["uTime"]?.SetValue(Main.GlobalTimeWrappedHourly);
            panelShader.Parameters["uHoverIntensity"]?.SetValue(panelHoverIntensity);
            sb.Draw(TextureAssets.MagicPixel.Value, panelRect, Color.White);
            sb.Restart(ss);
            var borderColor = Color.Lerp(new Color(20, 81, 63), new Color(27, 110, 85), panelHoverIntensity * 0.5f);
            var borderRects = new Rectangle[]
            {
                new((int)dims.X, (int)dims.Y, (int)dims.Width, BorderThickness),
                new((int)dims.X, (int)(dims.Y + dims.Height - BorderThickness), (int)dims.Width, BorderThickness),
                new((int)dims.X, (int)dims.Y, BorderThickness, (int)dims.Height),
                new((int)(dims.X + dims.Width - BorderThickness), (int)dims.Y, BorderThickness, (int)dims.Height)
            };
            foreach (var rect in borderRects)
            {
                sb.Draw(TextureAssets.MagicPixel.Value, rect, borderColor);
            }
            return false;
        }
        public override Color ModifyEnabledTextColor(bool enabled, Color color)
        {
            if (enabled)
            {
                return new Color(30, 174, 131);
            }
            else
            {
                return new Color(37, 120, 95);
            }
        }
        public override bool PreDrawModStateTextPanel(UIElement self, bool enabled) => false;
        public override void PostSetHoverColors(UIPanel element, bool hovered)
        {
            if (hovered)
            {
                element.BackgroundColor = Color.Lerp(element.BackgroundColor, Color.White, 0.1f);
            }
        }

    }
}