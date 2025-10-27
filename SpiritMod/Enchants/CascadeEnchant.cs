using SpiritMod.Items.Sets.CascadeSet.Armor;
using SpiritMod.Items.Sets.CascadeSet.Basking_Shark;
using SpiritMod.Items.Sets.CascadeSet.BubbleMine;
using SpiritMod.Items.Sets.CascadeSet.Reef_Wrath;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class CascadeEnchant : BaseEnchant
    {
        public override Color nameColor => new(173, 160, 138);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.rare = ItemRarityID.Blue;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddEffect<CascadeEffect>(Item);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<CascadeHelmet>()
                .AddIngredient<CascadeChestplate>()
                .AddIngredient<CascadeLeggings>()
                .AddIngredient<Basking_Shark>()
                .AddIngredient<Reef_Wrath>()
                .AddIngredient<BubbleMine>(140)
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }
        public class CascadeEffect : AccessoryEffect
        {
            public override Header ToggleHeader => null;
            public override int ToggleItemType => ModContent.ItemType<CascadeEnchant>();
        }
    }
}