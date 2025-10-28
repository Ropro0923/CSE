using ResonantSouls.SpiritMod.Forces;
using SpiritMod.Items.ByBiome.Briar.Consumables;
using SpiritMod.Items.Sets.GladeWraithDrops;
using SpiritMod.Items.Sets.HuskstalkSet;
using SpiritMod.Items.Sets.HuskstalkSet.ElderbarkArmor;
using ResonantSouls.SpiritMod.Core;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class ElderbarkEnchant : BaseEnchant
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Color nameColor => new(115, 141, 54);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.width = 44;
            Item.height = 32;
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
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class ElderbarkEffect : AccessoryEffect
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Header ToggleHeader => Header.GetHeader<AdventuresHeader>();
        public override int ToggleItemType => ModContent.ItemType<ElderbarkEnchant>();
    }
}