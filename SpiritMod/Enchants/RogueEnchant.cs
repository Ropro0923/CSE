using SpiritMod.Items.Accessory;
using SpiritMod.Items.Accessory.Leather;
using SpiritMod.Items.Armor;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class RogueEnchant : BaseEnchant
    {
        public override Color nameColor => new(216, 175, 113);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.value = 5000 + 2000 + 4000 + 30000 + 1200 + 400;
            Item.rare = ItemRarityID.Blue;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddEffect<RogueEffect>(Item);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<RogueHood>()
                .AddIngredient<RoguePlate>()
                .AddIngredient<RoguePants>()
                .AddIngredient<RogueCrest>()
                .AddIngredient<LeatherGlove>()
                .AddIngredient<LeatherBoots>()
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }
        public class RogueEffect : AccessoryEffect
        {
            public override Header ToggleHeader => null;
            public override int ToggleItemType => ModContent.ItemType<RogueEnchant>();
        }
    }
}