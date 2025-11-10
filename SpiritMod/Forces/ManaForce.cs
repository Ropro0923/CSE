using FargowiltasSouls.Content.Items.Accessories.Forces;
using FargowiltasSouls.Core.Toggler.Content;
using ResonantSouls.SpiritMod.Enchants;
using ResonantSouls.SpiritMod.Core;

namespace ResonantSouls.SpiritMod.Forces
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class ManaForce : BaseForce
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override string Texture => Debug.Placeholder;
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.value = ModContent.GetInstance<SlagTyrantEnchant>().Item.value + ModContent.GetInstance<SeraphEnchant>().Item.value + ModContent.GetInstance<RunicEnchant>().Item.value + ModContent.GetInstance<BloodcourtEnchant>().Item.value;
        }
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();

            Enchants[Type] =
            [
                ModContent.ItemType<SlagTyrantEnchant>(),
                ModContent.ItemType<SeraphEnchant>(),
                ModContent.ItemType<RunicEnchant>(),
                ModContent.ItemType<BloodcourtEnchant>(),
            ];
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            SetActive(player);
            player.AddEffect<SlagTyrantEffect>(Item);
            player.AddEffect<SeraphEffect>(Item);
            player.AddEffect<RunicEffect>(Item);
            player.AddEffect<BloodcourtEffect>(Item);
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
    public class ManaForceEffect : AccessoryEffect
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Header ToggleHeader => null;
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class ManaHeader : EnchantHeader
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override int Item => ModContent.ItemType<ManaForce>();
        public override float Priority => 1f;
    }
}