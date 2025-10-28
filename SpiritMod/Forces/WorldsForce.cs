using FargowiltasSouls.Content.Items.Accessories.Forces;
using FargowiltasSouls.Core.Toggler.Content;
using ResonantSouls.SpiritMod.Enchants;
using ResonantSouls.SpiritMod.Core;
using FargowiltasSouls.Core;

namespace ResonantSouls.SpiritMod.Forces
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class WorldsForce : BaseForce
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            Main.RegisterItemAnimation(Item.type, new DrawAnimationRectangularV(6, 1, 12));
            ItemID.Sets.AnimatesAsSoul[Item.type] = true;
            Enchants[Type] =
            [
                ModContent.ItemType<AstraliteEnchant>(),
                ModContent.ItemType<SpiritEnchant>(),
                ModContent.ItemType<FloranEnchant>(),
                ModContent.ItemType<GildedEnchant>(),
                ModContent.ItemType<GraniteEnchant>(),
                ModContent.ItemType<BismiteEnchant>(),
            ];
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            SetActive(player);
            player.AddEffect<AstraliteEffect>(Item);
            player.AddEffect<SpiritEffect>(Item);
            player.AddEffect<FloranEffect>(Item);
            player.AddEffect<GildedEffect>(Item);
            player.AddEffect<GraniteEffect>(Item);
            player.AddEffect<BismiteEffect>(Item);
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
    public class WorldsForceEffect : AccessoryEffect
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Header ToggleHeader => null;
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class WorldsHeader : EnchantHeader
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override int Item => ModContent.ItemType<WorldsForce>();
        public override float Priority => 1f;
    }
}