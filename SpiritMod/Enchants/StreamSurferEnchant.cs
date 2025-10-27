using SpiritMod.Items.Sets.RlyehianDrops;
using SpiritMod.Items.Sets.TideDrops;
using SpiritMod.Items.Sets.TideDrops.StreamSurfer;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class StreamSurferEnchant : BaseEnchant
    {
        public override Color nameColor => new(114, 212, 230);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.rare = ItemRarityID.Orange;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddEffect<StreamSurferEffect>(Item);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<StreamSurferHelmet>()
                .AddIngredient<StreamSurferChestplate>()
                .AddIngredient<StreamSurferLeggings>()
                .AddIngredient<CoconutGun>()
                .AddIngredient<TomeOfRylien>()
                .AddIngredient<Minifish>()
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }
        public class StreamSurferEffect : AccessoryEffect
        {
            public override Header ToggleHeader => null;
            public override int ToggleItemType => ModContent.ItemType<StreamSurferEnchant>();
        }
    }
}