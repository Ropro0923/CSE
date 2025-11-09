using ResonantSouls.SpiritMod.Forces;
using SpiritMod.Items.Consumable.Food;
using SpiritMod.Items.BossLoot.ScarabeusDrops.ChitinArmor;
using SpiritMod.Items.BossLoot.ScarabeusDrops;
using ResonantSouls.SpiritMod.Core;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class ChitinEnchant : BaseEnchant
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Color nameColor => new(141, 163, 239);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.width = 40;
            Item.height = 44;
            Item.rare = ItemRarityID.Blue;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddEffect<ChitinEffect>(Item);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<ChitinHelmet>()
                .AddIngredient<ChitinChestplate>()
                .AddIngredient<ChitinLeggings>()
                .AddIngredient<Hummus>()
                .AddIngredient<ChitinAxe>()
                .AddIngredient(ModCompatibility.SpiritMod.Mod.Find<ModItem>("GildedScarab").Type, 1)
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class ChitinEffect : AccessoryEffect
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Header ToggleHeader => Header.GetHeader<FoesHeader>();
        public override int ToggleItemType => ModContent.ItemType<ChitinEnchant>();
    }
}