using SpiritMod.Items.Accessory.Leather;
using SpiritMod.Items.Armor.WayfarerSet;
using SpiritMod.Items.Sets.ReefhunterSet;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class WayfarerEnchant : BaseEnchant
    {
        public override Color nameColor => new(169, 127, 110);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.rare = ItemRarityID.Orange;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddEffect<WayfarerEffect>(Item);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<WayfarerHead>()
                .AddIngredient<WayfarerBody>()
                .AddIngredient<WayfarerLegs>()
                .AddIngredient<ExplorerTreads>()
                .AddIngredient<TechBoots>()
                .AddIngredient<PendantOfTheOcean>()
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }
        public class WayfarerEffect : AccessoryEffect
        {
            public override Header ToggleHeader => null;
            public override int ToggleItemType => ModContent.ItemType<WayfarerEnchant>();
        }
    }
}