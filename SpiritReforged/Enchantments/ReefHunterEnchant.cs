using CSE.Core;
using SpiritReforged.Content.Ocean.Items.Reefhunter;
using SpiritReforged.Content.Ocean.Items.Reefhunter.CascadeArmor;

namespace CSE.SpiritReforged.Enchantments
{
    [ExtendsFromMod(ModCompatibility.SpiritReforged.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritReforged.Name)]
    public class ReefHunterEnchant : BaseEnchant
    {
        //    public override bool IsLoadingEnabled(Mod mod) => CSEConfig.Instance.SpiritReforged;
        public override bool IsLoadingEnabled(Mod mod) => false;
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.value = Item.sellPrice(0, 44, 0, 0);
        }
        public override Color nameColor => new(82, 194, 219);
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<CascadeHelmet>())
                .AddIngredient(ModContent.ItemType<CascadeChestplate>())
                .AddIngredient(ModContent.ItemType<CascadeLeggings>())
                .AddIngredient(ModContent.ItemType<ClawCannon>())
                .AddIngredient(ModContent.ItemType<ReefSpear>())
                .AddIngredient(ModContent.ItemType<UrchinStaff>())
                .AddTile(TileID.DemonAltar)
                .Register();
        }
        public class ReefHunterEffect : AccessoryEffect
        {
            public override Header ToggleHeader => null;
            public override int ToggleItemType => ModContent.ItemType<ReefHunterEnchant>();
        }
    }
}