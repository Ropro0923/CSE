using ResonantSouls.SpiritMod.Forces;
using SpiritMod.Items.Armor.Daybloom;
using SpiritMod.Items.Placeable.Furniture;
using SpiritMod.Items.Weapon.Magic;
using ResonantSouls.SpiritMod.Core;
using FargowiltasSouls.Core.ModPlayers;
using FargowiltasSouls;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class SunflowerEnchant : BaseEnchant
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Color nameColor => new(246, 197, 26);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.width = 44;
            Item.height = 32;
            Item.rare = ModContent.GetInstance<DaybloomHead>().Item.rare;
            Item.value = ModContent.GetInstance<DaybloomHead>().Item.value + ModContent.GetInstance<DaybloomBody>().Item.value + ModContent.GetInstance<DaybloomLegs>().Item.value + ModContent.GetInstance<HangingSunPot>().Item.value + ModContent.GetInstance<BriarFlowerItem>().Item.value + ModContent.GetInstance<CactusStaff>().Item.value;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddEffect<SunflowerEffect>(Item);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<DaybloomHead>()
                .AddIngredient<DaybloomBody>()
                .AddIngredient<DaybloomLegs>()
                .AddIngredient<HangingSunPot>()
                .AddIngredient<BriarFlowerItem>()
                .AddIngredient<CactusStaff>()
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class SunflowerEffect : AccessoryEffect
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Header ToggleHeader => Header.GetHeader<AdventuresHeader>();
        public override int ToggleItemType => ModContent.ItemType<SunflowerEnchant>();
    }
}