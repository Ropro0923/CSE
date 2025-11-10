using ResonantSouls.SpiritMod.Forces;
using SpiritMod.Items.BossLoot.InfernonDrops;
using SpiritMod.Items.BossLoot.InfernonDrops.InfernonArmor;
using ResonantSouls.SpiritMod.Core;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class PainMongerEnchant : BaseEnchant
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Color nameColor => new(234, 93, 15);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.width = 40;
            Item.height = 42;
            Item.rare = ModContent.GetInstance<InfernalVisor>().Item.rare;
            Item.value = ModContent.GetInstance<InfernalVisor>().Item.value + ModContent.GetInstance<InfernalBreastplate>().Item.value + ModContent.GetInstance<InfernalGreaves>().Item.value + ModContent.GetInstance<EyeOfTheInferno>().Item.value + ModContent.GetInstance<InfernalStaff>().Item.value + ModContent.GetInstance<SevenSins>().Item.value;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddEffect<PainMongerEffect>(Item);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<InfernalVisor>()
                .AddIngredient<InfernalBreastplate>()
                .AddIngredient<InfernalGreaves>()
                .AddIngredient<EyeOfTheInferno>()
                .AddIngredient<InfernalStaff>()
                .AddIngredient<SevenSins>()
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class PainMongerEffect : AccessoryEffect
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Header ToggleHeader => Header.GetHeader<FoesHeader>();
        public override int ToggleItemType => ModContent.ItemType<PainMongerEnchant>();
    }
}