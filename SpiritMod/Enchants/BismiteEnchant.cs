using SpiritMod.Items.Accessory.Leather;
using SpiritMod.Items.Sets.BismiteSet;
using SpiritMod.Items.Sets.BismiteSet.BismiteArmor;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class BismiteEnchant : BaseEnchant
    {
        public override Color nameColor => new(164, 202, 74);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.value = 1000 + 800 + 600 + 30000 + 6000 + 10000;
            Item.rare = ItemRarityID.Blue;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddEffect<BismiteEffect>(Item);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<BismiteHelmet>()
                .AddIngredient<BismiteChestplate>()
                .AddIngredient<BismiteLeggings>()
                .AddIngredient<BismiteShield>()
                .AddIngredient<BismiteChakra>()
                .AddIngredient<BismiteStaff>()
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }
        public class BismiteEffect : AccessoryEffect
        {
            public override Header ToggleHeader => null;
            public override int ToggleItemType => ModContent.ItemType<BismiteEnchant>();
        }
    }
}