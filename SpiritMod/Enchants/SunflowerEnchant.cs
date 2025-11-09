using ResonantSouls.SpiritMod.Forces;
using SpiritMod.Items.Armor.Daybloom;
using SpiritMod.Items.Placeable.Furniture;
using SpiritMod.Items.Weapon.Magic;
using ResonantSouls.SpiritMod.Core;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class SunflowerEnchant : BaseEnchant
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        
        public override Color nameColor => new(246, 197, 26);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.width = 44;
            Item.height = 32;
            Item.rare = ItemRarityID.White;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddEffect<SunflowerEffect>(Item);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<DaybloomHead>()
                .AddIngredient<DaybloomBody>()
                .AddIngredient<DaybloomLegs>()
                .AddIngredient<HangingSunPot>()
                .AddIngredient<PottedSakura>()
                .AddIngredient<CactusStaff>()
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class SunflowerEffect : AccessoryEffect
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Header ToggleHeader => Header.GetHeader<AdventuresHeader>();
        public override int ToggleItemType => ModContent.ItemType<SunflowerEnchant>();
    }
}