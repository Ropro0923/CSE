using FargowiltasSouls;
using FargowiltasSouls.Content.Items.Accessories.Souls;
using FargowiltasSouls.Content.Items.Materials;
using FargowiltasSouls.Core;
using ResonantSouls.SpiritMod.Forces;
using ResonantSouls.SpiritMod.Core;

namespace ResonantSouls.SpiritMod.Souls
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class EtherealitySoul : BaseSoul
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        internal static List<int> Forces =
        [
            ModContent.ItemType<AdventuresForce>(),
            ModContent.ItemType<AtlantisForce>(),
            ModContent.ItemType<FoesForce>(),
            ModContent.ItemType<ManaForce>(),
            ModContent.ItemType<WorldsForce>()
        ];
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            Main.RegisterItemAnimation(Item.type, new DrawAnimationRectangularV(6, 4, 5));
            ItemID.Sets.AnimatesAsSoul[Item.type] = true;
        }
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.rare = ItemRarityID.Expert;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            foreach (int force in Forces)
                player.FargoSouls().ForceEffects.Add(force);
                
            ModContent.GetInstance<AdventuresForce>().UpdateAccessory(player, hideVisual);
            ModContent.GetInstance<AtlantisForce>().UpdateAccessory(player, hideVisual);
            ModContent.GetInstance<FoesForce>().UpdateAccessory(player, hideVisual);
            ModContent.GetInstance<ManaForce>().UpdateAccessory(player, hideVisual);
            ModContent.GetInstance<WorldsForce>().UpdateAccessory(player, hideVisual);
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();

            foreach (int force in Forces)
                recipe.AddIngredient(force);

            recipe.AddIngredient<AbomEnergy>(10)

            .AddTile<CrucibleCosmosSheet>()
            .Register();
        }
    }
}