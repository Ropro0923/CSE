using ResonantSouls.SpiritMod.Forces;
using SpiritMod.Items.Sets.ClubSubclass;
using SpiritMod.Items.Sets.SlagSet;
using SpiritMod.Items.Sets.SlagSet.FieryArmor;
using ResonantSouls.SpiritMod.Core;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class SlagTyrantEnchant : BaseEnchant
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Color nameColor => new(251, 102, 17);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.width = 36;
            Item.height = 40;
            Item.rare = ModContent.GetInstance<ObsidiusHelm>().Item.rare;
            Item.value = ModContent.GetInstance<ObsidiusHelm>().Item.value + ModContent.GetInstance<ObsidiusPlate>().Item.value + ModContent.GetInstance<ObsidiusGreaves>().Item.value + ModContent.GetInstance<Blasphemer>().Item.value + ModContent.GetInstance<FieryMagicLauncher>().Item.value + ModContent.GetInstance<FierySummonStaff>().Item.value + ModContent.GetInstance<FierySummonStaff>().Item.value;
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
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class SlagTyrantEffect : AccessoryEffect
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Header ToggleHeader => Header.GetHeader<ManaHeader>();
        public override int ToggleItemType => ModContent.ItemType<SlagTyrantEnchant>();
    }
}