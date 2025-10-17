using SpiritMod.Items.Sets.BloodcourtSet;
using SpiritMod.Items.Sets.BloodcourtSet.BloodCourt;
using SpiritMod.Items.Sets.BloodcourtSet.Headsplitter;
using SpiritMod.Items.Sets.BloodcourtSet.Heartstrike;

namespace SOR.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class BloodcourtEnchant : BaseEnchant
    {
        public override Color nameColor => new(255, 99, 83);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.value = 3000 + 6000 + 4000 + 10000 + 25000 + 22500;
            Item.rare = ItemRarityID.Green;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddEffect<BloodcourtEffect>(Item);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<BloodCourtHead>()
                .AddIngredient<BloodCourtChestplate>()
                .AddIngredient<BloodCourtLeggings>()
                .AddIngredient<Headsplitter>()
                .AddIngredient<Heartstrike>()
                .AddIngredient<FangTome>()
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }
        public class BloodcourtEffect : AccessoryEffect
        {
            public override Header ToggleHeader => null;
            public override int ToggleItemType => ModContent.ItemType<BloodcourtEnchant>();
        }
    }
}