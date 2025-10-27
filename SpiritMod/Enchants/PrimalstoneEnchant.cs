using SpiritMod.Items.BossLoot.AtlasDrops;
using SpiritMod.Items.BossLoot.AtlasDrops.PrimalstoneArmor;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class PrimalstoneEnchant : BaseEnchant
    {
        public override Color nameColor => new(164, 193, 176);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.rare = ItemRarityID.Cyan;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddEffect<PrimalstoneEffect>(Item);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<PrimalstoneFaceplate>()
                .AddIngredient<PrimalstoneBreastplate>()
                .AddIngredient<PrimalstoneLeggings>()
                .AddIngredient<Mountain>()
                .AddIngredient<Earthshatter>()
                .AddIngredient<QuakeFist>()
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }
        public class PrimalstoneEffect : AccessoryEffect
        {
            public override Header ToggleHeader => null;
            public override int ToggleItemType => ModContent.ItemType<PrimalstoneEnchant>();
        }
    }
}