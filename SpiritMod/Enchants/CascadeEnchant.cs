using Fargowiltas.Content.Items.Tiles;
using SpiritMod.Items.Sets.CascadeSet.Armor;
using SpiritMod.Items.Sets.CascadeSet.Basking_Shark;
using SpiritMod.Items.Sets.CascadeSet.Mantaray_Hunting_Harpoon;
using SpiritMod.Items.Sets.CascadeSet.Reef_Wrath;

namespace SOR.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class CascadeEnchant : BaseEnchant
    {
        public override string Texture => $"{Mod.Name}/SpiritMod/Enchants/CascadeEnchant";
        public override bool IsLoadingEnabled(Mod mod) => SORConfig.Instance.SpiritMod;
        public override Color nameColor => new(154, 112, 80);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.rare = ItemRarityID.Blue;  
            Item.value = Item.sellPrice(gold: 29, silver: 44);
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
                .AddIngredient<Mantaray_Hunting_Harpoon>()
                .AddIngredient<Reef_Wrath>()
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
