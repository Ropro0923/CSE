using SpiritMod.Items.Sets.SpiritSet;
using SpiritMod.Items.Sets.SpiritSet.SpiritArmor;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class SpiritEnchant : BaseEnchant
    {
        public override Color nameColor => new(107, 107, 223);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.rare = ItemRarityID.Pink;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddEffect<SpiritEffect>(Item);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<SpiritHeadgear>()
                .AddIngredient<SpiritBodyArmor>()
                .AddIngredient<SpiritLeggings>()
                .AddIngredient<SpiritSpear>()
                .AddIngredient<Revenant>()
                .AddIngredient<SpiritWand>()
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }
        public class SpiritEffect : AccessoryEffect
        {
            public override Header ToggleHeader => null;
            public override int ToggleItemType => ModContent.ItemType<SpiritEnchant>();
        }
    }
}