using SpiritMod.Items.BossLoot.DuskingDrops;
using SpiritMod.Items.BossLoot.DuskingDrops.DuskArmor;
using SpiritMod.Items.DonatorItems;
using SpiritMod.Items.Sets.SpearsMisc.DuskLance;

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
            Item.value = 70000 + 50000 + 40000 + 25700 + 180000 + 80000;
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
                .AddIngredient<DuskLeggings>()
                .AddIngredient<DuskPlate>()
                .AddIngredient<BladeofYouKai>()
                .AddIngredient<DuskLance>()
                .AddIngredient<DuskPendant>()
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