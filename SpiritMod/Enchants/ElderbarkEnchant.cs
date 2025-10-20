using SpiritMod.Items.ByBiome.Briar.Consumables;
using SpiritMod.Items.Sets.GladeWraithDrops;
using SpiritMod.Items.Sets.HuskstalkSet;
using SpiritMod.Items.Sets.HuskstalkSet.ElderbarkArmor;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class ElderbarkEnchant : BaseEnchant
    {
        public override Color nameColor => new(115, 141, 54);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.value = 100 + 7500 + 250;
            Item.rare = ItemRarityID.White;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddEffect<ElderbarkEffect>(Item);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<ElderbarkHead>()
                .AddIngredient<ElderbarkChest>()
                .AddIngredient<ElderbarkLegs>()
                .AddIngredient<HuskstalkSword>()
                .AddIngredient<HuskstalkStaff>()
                .AddIngredient<Durian>()
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }
        public class ElderbarkEffect : AccessoryEffect
        {
            public override Header ToggleHeader => null;
            public override int ToggleItemType => ModContent.ItemType<ElderbarkEnchant>();
        }
    }
}