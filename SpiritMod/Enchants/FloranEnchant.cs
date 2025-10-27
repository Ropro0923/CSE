using SpiritMod.Items.Sets.ClubSubclass;
using SpiritMod.Items.Sets.FloranSet;
using SpiritMod.Items.Sets.FloranSet.FloranArmor;
using SpiritMod.Items.Sets.GladeWraithDrops;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class FloranEnchant : BaseEnchant
    {
        public override Color nameColor => new(176, 216, 5);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.rare = ItemRarityID.Green;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddEffect<FloranEffect>(Item);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<FHelmet>()
                .AddIngredient<FPlate>()
                .AddIngredient<FLegs>()
                .AddIngredient<HuskstalkStaff>()
                .AddIngredient<FloranBludgeon>()
                .AddIngredient<FloranReacher>()
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }
        public class FloranEffect : AccessoryEffect
        {
            public override Header ToggleHeader => null;
            public override int ToggleItemType => ModContent.ItemType<FloranEnchant>();
        }
    }
}
