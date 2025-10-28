using FargowiltasSouls.Content.Items.Accessories.Forces;
using FargowiltasSouls.Core;
using FargowiltasSouls.Core.Toggler.Content;
using ResonantSouls.SpiritMod.Core;
using ResonantSouls.SpiritMod.Enchants;

namespace ResonantSouls.SpiritMod.Forces
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class AdventuresForce : BaseForce
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            Main.RegisterItemAnimation(Item.type, new DrawAnimationRectangularV(6, 2, 3));
            ItemID.Sets.AnimatesAsSoul[Item.type] = true;
            Enchants[Type] =
            [
                ModContent.ItemType<RogueEnchant>(),
                ModContent.ItemType<MarksmanEnchant>(),
                ModContent.ItemType<SunflowerEnchant>(),
                ModContent.ItemType<WayfarerEnchant>(),
                ModContent.ItemType<ElderbarkEnchant>(),
            ];
        }
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.width = 44;
            Item.height = 24;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            SetActive(player);
            player.AddEffect<RogueEffect>(Item);
            player.AddEffect<MarksmanEffect>(Item);
            player.AddEffect<SunflowerEffect>(Item);
            player.AddEffect<WayfarerEffect>(Item);
            player.AddEffect<ElderbarkEffect>(Item);
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
    public class AdventuresForceEffect : AccessoryEffect
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Header ToggleHeader => null;
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class AdventuresHeader : EnchantHeader
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override int Item => ModContent.ItemType<AdventuresForce>();
        public override float Priority => 1f;
    }
}