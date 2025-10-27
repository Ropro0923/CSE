using SpiritMod.Items.Accessory.Leather;
using SpiritMod.Items.Armor.LeatherArmor;
using SpiritMod.Items.DonatorItems;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class MarksmanEnchant : BaseEnchant
    {
        public override Color nameColor => new(134, 94, 64);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.rare = ItemRarityID.Blue;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddEffect<MarksmanEffect>(Item);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<LeatherHood>()
                .AddIngredient<LeatherPlate>()
                .AddIngredient<LeatherLegs>()
                .AddIngredient<DodgeBall>()
                .AddIngredient<LeatherShield>()
                .AddIngredient<LeatherBoots>()
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }
        public class MarksmanEffect : AccessoryEffect
        {
            public override Header ToggleHeader => null;
            public override int ToggleItemType => ModContent.ItemType<MarksmanEnchant>();
        }
    }
}