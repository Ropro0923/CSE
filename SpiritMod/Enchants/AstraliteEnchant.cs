using ResonantSouls.SpiritMod.Core;
using ResonantSouls.SpiritMod.Forces;
using SpiritMod.Items.BossLoot.StarplateDrops;
using SpiritMod.Items.BossLoot.StarplateDrops.StarArmor;
using SpiritMod.Items.BossLoot.StarplateDrops.StarplateGlove;
using SpiritMod.Items.Sets.SwordsMisc.AlphaBladeTree;
using SpiritMod.Items.Sets.MagicMisc.NightSkyStaff;
using SpiritMod.Items.Sets.GunsMisc.MeteoriteSpewer;

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
            Item.rare = ItemRarityID.Orange;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddEffect<AstraliteEffect>(Item);
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
    public class AstraliteEffect : AccessoryEffect
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Header ToggleHeader => Header.GetHeader<WorldsHeader>();
        public override int ToggleItemType => ModContent.ItemType<AstraliteEnchant>();
    }
}