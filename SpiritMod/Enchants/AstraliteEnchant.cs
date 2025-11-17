using ResonantSouls.SpiritMod.Core;
using ResonantSouls.SpiritMod.Forces;
using SpiritMod.Items.BossLoot.StarplateDrops;
using SpiritMod.Items.BossLoot.StarplateDrops.StarArmor;
using SpiritMod.Items.Sets.MagicMisc.NightSkyStaff;
using SpiritMod.Items.Sets.GunsMisc.MeteoriteSpewer;
using Terraria.Audio;

namespace ResonantSouls.SpiritMod.Enchants
{
	[ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
	[JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
	public class AstraliteEnchant : BaseEnchant
	{
		public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
		public override Color nameColor => new(234, 197, 128);
		public override void SetDefaults()
		{
			base.SetDefaults();
			Item.width = 36;
			Item.height = 40;
			Item.rare = ModContent.GetInstance<StarMask>().Item.rare;
			Item.value = ModContent.GetInstance<StarMask>().Item.value + ModContent.GetInstance<StarPlate>().Item.value + ModContent.GetInstance<StarLegs>().Item.value + ModContent.GetInstance<StarMap>().Item.value + ModContent.GetInstance<NightSkyStaff>().Item.value + ModContent.GetInstance<Meteorite_Spewer>().Item.value;
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.AddEffect<AstraliteJumpsEffect>(Item);
			player.AddEffect<AstraliteDashEffect>(Item);
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<StarMask>()
				.AddIngredient<StarPlate>()
				.AddIngredient<StarLegs>()
				.AddIngredient<StarMap>()
				.AddIngredient<NightSkyStaff>()
				.AddIngredient<Meteorite_Spewer>()
				.AddTile<EnchantedTreeSheet>()
				.Register();
		}
	}
	[ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
	[JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
	public class AstraliteJumpsEffect : AccessoryEffect
	{
		public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
		public override Header ToggleHeader => Header.GetHeader<WorldsHeader>();
		public override int ToggleItemType => ModContent.ItemType<AstraliteEnchant>();
        public override bool ExtraJumpEffect => true;
		public override void PostUpdateEquips(Player player)
		{
			player.GetJumpState<AstraliteJumps>().Enable();
		}
	}
	[ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
	[JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
	public class AstraliteDashEffect : AccessoryEffect
	{
		public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
		public override Header ToggleHeader => Header.GetHeader<WorldsHeader>();
		public override int ToggleItemType => ModContent.ItemType<AstraliteEnchant>();
        public override void PostUpdate(Player player)
        {
            
        }
	}
	[ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
	[JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
	public class AstraliteJumps : ExtraJump
	{
		public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
		public override Position GetDefaultPosition() => new After(BlizzardInABottle);
		public override float GetDurationMultiplier(Player player)
		{
			return player.GetModPlayer<AstraliteJumpPlayer>().jumpsRemaining switch
			{
				1 => 0.2f,
				2 => 0.4f,
				3 => 0.6f,
				_ => 0f
			};
		}
		public override void OnRefreshed(Player player)
		{
			player.GetModPlayer<AstraliteJumpPlayer>().jumpsRemaining = 3;
		}
		public override void OnStarted(Player player, ref bool playSound)
		{
			ref int jumps = ref player.GetModPlayer<AstraliteJumpPlayer>().jumpsRemaining;
			int offsetY = player.height;
			if (player.gravDir == -1f)
				offsetY = 0;
			offsetY -= 16;
			Vector2 center = player.Top + new Vector2(0, offsetY);
			if (jumps == 3)
			{
				const int numDusts = 40;
				for (int i = 0; i < numDusts; i++)
				{
					(float sin, float cos) = SinCos(ToRadians(i * 360 / numDusts));
					float amplitudeX = cos * (player.width + 10) / 2f;
					float amplitudeY = sin * 6;
					Dust dust = Dust.NewDustPerfect(center + new Vector2(amplitudeX, amplitudeY), DustID.BlueFlare, -player.velocity * 0.5f, Scale: 1f);
					dust.noGravity = true;
				}
			}
			else if (jumps == 2)
			{
				const int numDusts = 30;
				for (int i = 0; i < numDusts; i++)
				{
					(float sin, float cos) = SinCos(ToRadians(i * 360 / numDusts));

					float amplitudeX = cos * (player.width + 2) / 2f;
					float amplitudeY = sin * 5;

					Dust dust = Dust.NewDustPerfect(center + new Vector2(amplitudeX, amplitudeY), DustID.BlueFlare, -player.velocity * 0.35f, Scale: 1f);
					dust.noGravity = true;
				}
			}
			else
			{
				const int numDusts = 24;
				for (int i = 0; i < numDusts; i++)
				{
					(float sin, float cos) = SinCos(ToRadians(i * 360 / numDusts));
					float amplitudeX = cos * (player.width - 4) / 2f;
					float amplitudeY = sin * 3;
					Dust dust = Dust.NewDustPerfect(center + new Vector2(amplitudeX, amplitudeY), DustID.BlueFlare, -player.velocity * 0.2f, Scale: 1f);
					dust.noGravity = true;
				}
			}
			playSound = false;
			float pitch = jumps switch
			{
				1 => 0.5f,
				2 => 0.1f,
				3 => -0.2f,
				_ => 0
			};
			SoundEngine.PlaySound(SoundID.Item8 with { Pitch = pitch, PitchVariance = 0.04f }, player.Bottom);
			jumps--;
			if (jumps > 0)
				player.GetJumpState(this).Available = true;
		}
	}
	[ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
	[JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
	public class AstraliteJumpPlayer : ModPlayer
	{
		public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
		public int jumpsRemaining;
	}
}