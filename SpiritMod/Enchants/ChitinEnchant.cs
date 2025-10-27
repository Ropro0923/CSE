using SpiritMod.Items.BossLoot.ScarabeusDrops.AdornedBow;
using SpiritMod.Items.BossLoot.ScarabeusDrops.ChitinArmor;
using SpiritMod.Items.BossLoot.ScarabeusDrops.Khopesh;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class ChitinEnchant : BaseEnchant
    {
        public override Color nameColor => new(141, 163, 239);
        public override void SetDefaults()
        {
            base.SetDefaults();
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
                .AddIngredient<RoyalKhopesh>()
                .AddIngredient<ScarabBow>()
                .AddIngredient(ModCompatibility.SpiritMod.Mod.Find<ModItem>("GildedScarab").Type, 1)
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }
        public class ChitinEffect : AccessoryEffect
        {
            public override Header ToggleHeader => null;
            public override int ToggleItemType => ModContent.ItemType<ChitinEnchant>();
        }
    }
}