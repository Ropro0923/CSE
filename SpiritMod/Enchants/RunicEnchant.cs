using SpiritMod.Items.Sets.RunicSet;
using SpiritMod.Items.Sets.RunicSet.RunicArmor;
using SpiritMod.Items.Sets.SpiritSet;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class RunicEnchant : BaseEnchant
    {
        public override Color nameColor => new(35, 200, 254);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.rare = ItemRarityID.Pink;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddEffect<RunicEffect>(Item);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<RunicHood>()
                .AddIngredient<RunicPlate>()
                .AddIngredient<RunicGreaves>()
                .AddIngredient<SpiritRune>()
                .AddIngredient<PhantomArc>()
                .AddIngredient<SpiritGun>()
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }
        public class RunicEffect : AccessoryEffect
        {
            public override Header ToggleHeader => null;
            public override int ToggleItemType => ModContent.ItemType<RunicEnchant>();
        }
    }
}