using ResonantSouls.SpiritMod.Forces;
using SpiritMod.Items.Sets.SpiritSet;
using SpiritMod.Items.Sets.SpiritSet.SpiritArmor;
using ResonantSouls.SpiritMod.Core;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class SpiritEnchant : BaseEnchant
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Color nameColor => new(107, 107, 223);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.width = 42;
            Item.height = 40;
            Item.rare = ModContent.GetInstance<SpiritHeadgear>().Item.rare;
            Item.value = ModContent.GetInstance<SpiritHeadgear>().Item.value + ModContent.GetInstance<SpiritBodyArmor>().Item.value + ModContent.GetInstance<SpiritLeggings>().Item.value + ModContent.GetInstance<SpiritSpear>().Item.value + ModContent.GetInstance<Revenant>().Item.value + ModContent.GetInstance<SpiritWand>().Item.value;
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
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class SpiritEffect : AccessoryEffect
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Header ToggleHeader => Header.GetHeader<WorldsHeader>();
        public override int ToggleItemType => ModContent.ItemType<SpiritEnchant>();
    }
}