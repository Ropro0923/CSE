using SpiritMod.Items.Sets.ClubSubclass;
using SpiritMod.Items.Sets.SlagSet;
using SpiritMod.Items.Sets.SlagSet.FieryArmor;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class SlagTyrantEnchant : BaseEnchant
    {
        public override Color nameColor => new(251, 102, 17);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.rare = ItemRarityID.Orange;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddEffect<SlagTyrantEffect>(Item);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<ObsidiusHelm>()
                .AddIngredient<ObsidiusPlate>()
                .AddIngredient<ObsidiusGreaves>()
                .AddIngredient<Blasphemer>()
                .AddIngredient<FieryMagicLauncher>()
                .AddIngredient<FierySummonStaff>()
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }
        public class SlagTyrantEffect : AccessoryEffect
        {
            public override Header ToggleHeader => null;
            public override int ToggleItemType => ModContent.ItemType<SlagTyrantEnchant>();
        }
    }
}