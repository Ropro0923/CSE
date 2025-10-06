using CSE.Core;
using SpiritReforged.Content.Vanilla.Leather.MarksmanArmor;

namespace CSE.SpiritReforged.Enchantments
{
    [ExtendsFromMod(ModCompatibility.SpiritReforged.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritReforged.Name)]
    public class AncientMarksmansEnchant : BaseEnchant
    {
        public override bool IsLoadingEnabled(Mod mod) => CSEConfig.Instance.SpiritReforged;
        public override void SetDefaults()
        {
            base.SetDefaults();
        }
        public override Color nameColor => new(44, 46, 33);
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<AncientMarksmanHood>())
                .AddIngredient(ModContent.ItemType<AncientMarksmanPlate>())
                .AddIngredient(ModContent.ItemType<AncientMarksmanLegs>())
                .AddTile(TileID.DemonAltar)
                .Register();
        }
        public class AncientMarksmansEffect : AccessoryEffect
        {
            public override Header ToggleHeader => null;
            public override int ToggleItemType => ModContent.ItemType<AncientMarksmansEnchant>();
        }
    }
}