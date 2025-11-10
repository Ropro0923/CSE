using ResonantSouls.SpiritMod.Forces;
using SpiritMod.Items.Sets.RunicSet;
using SpiritMod.Items.Sets.RunicSet.RunicArmor;
using SpiritMod.Items.Sets.SpiritSet;
using ResonantSouls.SpiritMod.Core;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class RunicEnchant : BaseEnchant
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Color nameColor => new(35, 200, 254);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.width = 36;
            Item.height = 40;
            Item.rare = ModContent.GetInstance<RunicHood>().Item.rare;
            Item.value = ModContent.GetInstance<RunicHood>().Item.value + ModContent.GetInstance<RunicPlate>().Item.value + ModContent.GetInstance<RunicGreaves>().Item.value + ModContent.GetInstance<SpiritRune>().Item.value + ModContent.GetInstance<PhantomArc>().Item.value + ModContent.GetInstance<SpiritGun>().Item.value;
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
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class RunicEffect : AccessoryEffect
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Header ToggleHeader => Header.GetHeader<ManaHeader>();
        public override int ToggleItemType => ModContent.ItemType<RunicEnchant>();
    }
}