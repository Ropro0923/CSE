using SpiritMod.Items.Armor.Daybloom;
using SpiritMod.Items.Placeable.Furniture;
using SpiritMod.Items.Weapon.Magic;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class SunflowerEnchant : BaseEnchant
    {
        public override Color nameColor => new(246, 197, 26);
        public override void SetDefaults()
        {
            base.SetDefaults();
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
                .AddIngredient<BriarFlowerItem>()
                .AddIngredient<CactusStaff>()
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }
        public class SunflowerEffect : AccessoryEffect
        {
            public override Header ToggleHeader => null;
            public override int ToggleItemType => ModContent.ItemType<SunflowerEnchant>();
        }
    }
}