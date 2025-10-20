using SpiritMod.Items.Consumable.Food;
using SpiritMod.Items.Sets.FrigidSet;
using SpiritMod.Items.Sets.FrigidSet.FrigidArmor;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class FrigidEnchant : BaseEnchant
    {
        public override Color nameColor => new(67, 173, 247);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.value = 1100 + 1100 + 1100 + 16000 + 5000 + 250 * 30;
            Item.rare = ItemRarityID.Blue;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddEffect<FrigidEffect>(Item);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<FrigidHelm>()
                .AddIngredient<FrigidChestplate>()
                .AddIngredient<FrigidLegs>()
                .AddIngredient<IcySpear>()
                .AddIngredient<FrostSpine>()
                .AddIngredient<IceBerries>()
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }
        public class FrigidEffect : AccessoryEffect
        {
            public override Header ToggleHeader => null;
            public override int ToggleItemType => ModContent.ItemType<FrigidEnchant>();
        }
    }
}