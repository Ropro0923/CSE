using FargowiltasSouls.Content.Items.Accessories.Forces;
using FargowiltasSouls.Core.Toggler.Content;
using ResonantSouls.SpiritMod.Enchants;
using ResonantSouls.SpiritMod.Core;

namespace ResonantSouls.SpiritMod.Forces
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class AtlantisForce : BaseForce
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override string Texture => Debug.Placeholder;
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();

            Enchants[Type] =
            [
                ModContent.ItemType<FrigidEnchant>(),
                ModContent.ItemType<StreamSurferEnchant>(),
                ModContent.ItemType<CryoliteEnchant>(),
                ModContent.ItemType<CascadeEnchant>(),
            ];
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            SetActive(player);
            player.AddEffect<FrigidEffect>(Item);
            player.AddEffect<StreamSurferEffect>(Item);
            player.AddEffect<CryoliteEffect>(Item);
            player.AddEffect<CascadeEffect>(Item);
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
    public class AtlantisForceEffect : AccessoryEffect
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Header ToggleHeader => null;
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class AtlantisHeader : EnchantHeader
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override int Item => ModContent.ItemType<AtlantisForce>();
        public override float Priority => 1f;
    }
}