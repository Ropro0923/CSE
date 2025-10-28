using ResonantSouls.SpiritMod.Forces;
using SpiritMod.Items.Consumable.Food;
using SpiritMod.Items.Sets.FrigidSet;
using SpiritMod.Items.Sets.FrigidSet.FrigidArmor;
using ResonantSouls.SpiritMod.Core;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class FrigidEnchant : BaseEnchant
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Color nameColor => new(67, 173, 247);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.width = 36;
            Item.height = 40;
            Item.rare = ItemRarityID.Blue;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddEffect<FrigidEffect>(Item);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<FrigidHelm>()
                .AddIngredient<FrigidChestplate>()
                .AddIngredient<FrigidLegs>()
                .AddIngredient<IcySpear>()
                .AddIngredient<FrostSpine>()
                .AddIngredient<IceBerries>()
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class FrigidEffect : AccessoryEffect
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Header ToggleHeader => Header.GetHeader<AtlantisHeader>();
        public override int ToggleItemType => ModContent.ItemType<FrigidEnchant>();
    }
}