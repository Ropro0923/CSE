using ResonantSouls.SpiritMod.Forces;
using SpiritMod.Items.BossLoot.ScarabeusDrops.AdornedBow;
using SpiritMod.Items.BossLoot.ScarabeusDrops.ChitinArmor;
using SpiritMod.Items.BossLoot.ScarabeusDrops.Khopesh;
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
            Item.rare = ModContent.GetInstance<ChitinHelmet>().Item.rare;
            Item.value = ModContent.GetInstance<ChitinHelmet>().Item.value + ModContent.GetInstance<ChitinChestplate>().Item.value + ModContent.GetInstance<ChitinLeggings>().Item.value + ModContent.GetInstance<RoyalKhopesh>().Item.value + ModContent.GetInstance<ScarabBow>().Item.value + ModContent.GetModItem(ModCompatibility.SpiritMod.Mod.Find<ModItem>("GildedScarab").Type).Item.value;
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
                .AddIngredient<RoyalKhopesh>()
                .AddIngredient<ScarabBow>()
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