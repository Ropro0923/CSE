using ResonantSouls.SpiritMod.Forces;
using SpiritMod.Items.Accessory;
using SpiritMod.Items.Accessory.Leather;
using SpiritMod.Items.Armor;
using SpiritMod.Items.Weapon.Thrown;
using ResonantSouls.SpiritMod.Core;
using FargowiltasSouls.Content.UI.Elements;
using FargowiltasSouls;
using Terraria.Audio;
using FargowiltasSouls.Core.ModPlayers;
using SpiritMod;
using ResonantSouls.SpiritMod.Common;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class RogueEnchant : BaseEnchant
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Color nameColor => new(216, 175, 113);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.width = 44;
            Item.height = 32;
            Item.rare = ModContent.GetInstance<RogueHood>().Item.rare;
            Item.value = ModContent.GetInstance<RogueHood>().Item.value + ModContent.GetInstance<RoguePlate>().Item.value + ModContent.GetInstance<RoguePants>().Item.value + ModContent.GetInstance<AssassinMagazine>().Item.value + ModContent.GetInstance<LeatherGlove>().Item.value + ModContent.GetInstance<Kunai_Throwing>().Item.value * 250;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddEffect<RogueKunai>(Item);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<RogueHood>()
                .AddIngredient<RoguePlate>()
                .AddIngredient<RoguePants>()
                .AddIngredient<AssassinMagazine>()
                .AddIngredient<LeatherGlove>()
                .AddIngredient<Kunai_Throwing>(250)
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }
        public override int DamageTooltip(out DamageClass damageClass, out Color? tooltipColor, out int? scaling)
        {
            ModContent.TryFind("ThrowerUnification", "UnitedModdedThrower", out DamageClass Thrower);
            damageClass = ModCompatibility.ThrowerUnification.Loaded ? Thrower : DamageClass.Ranged;
            tooltipColor = null;
            scaling = null;
            return RogueKunai.BaseDamage(Main.LocalPlayer);
        }
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class RogueKunai : AccessoryEffect
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public static int BaseDamage(Player player) => player.ForceEffect<RogueKunai>() ? 300 : 30;
        public override Header ToggleHeader => Header.GetHeader<AdventuresHeader>();
        public override int ToggleItemType => ModContent.ItemType<RogueEnchant>();
        public override void PostUpdate(Player player)
        {
            SpiritEffectPlayer SpiritEffectPlayer = player.SpiritEffectPlayer();
            SpiritEffectPlayer.Kunai = true;
            if (player.whoAmI == Main.myPlayer)
                CooldownBarManager.Activate("KunaiCooldown", ResonantSoulsUtilities.GetEnchantTexture("RogueEnchant").Value, new(216, 175, 113),
                () => (float)SpiritEffectPlayer.KunaiCharge / SpiritEffectPlayer.KunaiCooldown, activeFunction: player.HasEffect<RogueKunai>, displayAtFull: false);
        }
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public partial class SpiritEffectPlayer : ModPlayer
    {
        public int KunaiCharge = 0;
        public int KunaiCooldown;
        public bool Kunai;
        public override void ResetEffects()
        {
            Kunai = false;
        }
        public override void PostUpdate()
        {
            KunaiCooldown = Player.ForceEffect<RogueKunai>() ? 5 * 60 : 8 * 60;
            if (KunaiCharge < KunaiCooldown)
                KunaiCharge++;
            if ((Player.dashDelay < 0 || Player.eocDash > 0) && KunaiCharge >= KunaiCooldown)
                ThrowKunai(Player);
        }
        public override void OnExtraJumpStarted(ExtraJump jump, ref bool playSound)
        {
            if (KunaiCharge >= KunaiCooldown)
                ThrowKunai(Player);
        }
        public void ThrowKunai(Player Player)
        {
            KunaiCharge = 0;
            for (int i = -2; i <= 2; i += 2)
            {
                Projectile.NewProjectile(Player.GetSource_EffectItem<RogueKunai>(), Player.Center, new(30 * Player.direction, ((Main.MouseWorld.Y - Player.Center.Y) / 16) + i), ModContent.ProjectileType<Projectiles.RogueKunai>(), RogueKunai.BaseDamage(Player), 2f, Player.whoAmI);
            }
        }
    }
}