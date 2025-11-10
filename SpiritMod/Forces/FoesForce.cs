using FargowiltasSouls.Content.Items.Accessories.Forces;
using FargowiltasSouls.Core.Toggler.Content;
using ResonantSouls.SpiritMod.Enchants;
using ResonantSouls.SpiritMod.Core;
using FargowiltasSouls.Core;

namespace ResonantSouls.SpiritMod.Forces
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class FoesForce : BaseForce
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();

            Main.RegisterItemAnimation(Item.type, new DrawAnimationRectangularV(6, 1, 10));
            ItemID.Sets.AnimatesAsSoul[Item.type] = true;

            Enchants[Type] =
            [
                ModContent.ItemType<ChitinEnchant>(),
                ModContent.ItemType<DuskEnchant>(),
                ModContent.ItemType<PainMongerEnchant>(),
                ModContent.ItemType<PrimalstoneEnchant>(),
                ModContent.ItemType<ApostleEnchant>(),
            ];
        }
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.width = 84;
            Item.height = 780;
            Item.value = ModContent.GetInstance<ChitinEnchant>().Item.value + ModContent.GetInstance<DuskEnchant>().Item.value + ModContent.GetInstance<PainMongerEnchant>().Item.value + ModContent.GetInstance<PrimalstoneEnchant>().Item.value + ModContent.GetInstance<ApostleEnchant>().Item.value;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            SetActive(player);
            player.AddEffect<ChitinEffect>(Item);
            player.AddEffect<DuskEffect>(Item);
            player.AddEffect<PainMongerEffect>(Item);
            player.AddEffect<PrimalstoneEffect>(Item);
            player.AddEffect<ApostleEffect>(Item);
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();

            foreach (int ench in Enchants[Type])
                recipe.AddIngredient(ench);

            recipe.AddTile(ModContent.Find<ModTile>("Fargowiltas", "CrucibleCosmosSheet"));
            recipe.Register();
        }
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class FoesForceEffect : AccessoryEffect
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Header ToggleHeader => null;
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class FoesHeader : EnchantHeader
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override int Item => ModContent.ItemType<FoesForce>();
        public override float Priority => 1f;
    }

}