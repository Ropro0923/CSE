using ResonantSouls.SpiritMod.Forces;
using ResonantSouls.SpiritMod.Core;
using SpiritMod.Items.Sets.MarbleSet.MarbleArmor;
using SpiritMod.Items.Sets.MarbleSet;
using SpiritMod.Items.Sets.ArcaneZoneSubclass;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class GildedEnchant : BaseEnchant
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Color nameColor => new(230, 239, 255);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.width = 46;
            Item.height = 42;
            Item.rare = ItemRarityID.Green;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddEffect<GildedEffect>(Item);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<MarbleHelm>()
                .AddIngredient<MarbleChest>()
                .AddIngredient<MarbleStaff>()
                .AddIngredient<MarbleBident>()
                .AddIngredient<DefenseCodex>()
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class GildedEffect : AccessoryEffect
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Header ToggleHeader => Header.GetHeader<WorldsHeader>();
        public override int ToggleItemType => ModContent.ItemType<GildedEnchant>();
    }
}