using SpiritMod.Items.BossLoot.DuskingDrops;
using SpiritMod.Items.BossLoot.DuskingDrops.DuskArmor;
using SpiritMod.Items.DonatorItems;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class DuskEnchant : BaseEnchant
    {
        public override Color nameColor => new(164, 122, 255);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.rare = ItemRarityID.Pink;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddEffect<DuskEffect>(Item);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<DuskHood>()
                .AddIngredient<DuskPlate>()
                .AddIngredient<DuskLeggings>()
                .AddIngredient<BladeofYouKai>()
                .AddIngredient<Shadowmoor>()
                .AddIngredient<UmbraStaff>()
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }
        public class DuskEffect : AccessoryEffect
        {
            public override Header ToggleHeader => null;
            public override int ToggleItemType => ModContent.ItemType<DuskEnchant>();
        }
    }
}