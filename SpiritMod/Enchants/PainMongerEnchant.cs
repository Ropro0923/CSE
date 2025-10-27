using SpiritMod.Items.BossLoot.InfernonDrops;
using SpiritMod.Items.BossLoot.InfernonDrops.InfernonArmor;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class PainMongerEnchant : BaseEnchant
    {
        public override Color nameColor => new(234, 93, 15);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.rare = ItemRarityID.Pink;
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
        public class PainMongerEffect : AccessoryEffect
        {
            public override Header ToggleHeader => null;
            public override int ToggleItemType => ModContent.ItemType<PainMongerEnchant>();
        }
    }
}