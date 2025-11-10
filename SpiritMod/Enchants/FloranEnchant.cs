using ResonantSouls.SpiritMod.Forces;
using SpiritMod.Items.Sets.ClubSubclass;
using SpiritMod.Items.Sets.FloranSet;
using SpiritMod.Items.Sets.FloranSet.FloranArmor;
using SpiritMod.Items.Sets.GladeWraithDrops;
using SpiritMod.Items.Sets.ArcaneZoneSubclass;
using ResonantSouls.SpiritMod.Core;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class FloranEnchant : BaseEnchant
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Color nameColor => new(176, 216, 5);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.width = 36;
            Item.height = 40;
            Item.rare = ModContent.GetInstance<FHelmet>().Item.rare;
            Item.value = ModContent.GetInstance<FHelmet>().Item.value + ModContent.GetInstance<FPlate>().Item.value + ModContent.GetInstance<FLegs>().Item.value + ModContent.GetInstance<HuskstalkStaff>().Item.value + ModContent.GetInstance<FloranBludgeon>().Item.value + ModContent.GetInstance<FloranReacher>().Item.value;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddEffect<FloranEffect>(Item);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<FHelmet>()
                .AddIngredient<FPlate>()
                .AddIngredient<FLegs>()
                .AddIngredient<HuskstalkStaff>()
                .AddIngredient<FloranBludgeon>()
                .AddIngredient<StaminaCodex>()
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class FloranEffect : AccessoryEffect
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Header ToggleHeader => Header.GetHeader<WorldsHeader>();
        public override int ToggleItemType => ModContent.ItemType<FloranEnchant>();
    }
}