using ResonantSouls.SpiritMod.Forces;
using SpiritMod.Items.Sets.CascadeSet.Armor;
using SpiritMod.Items.Sets.CascadeSet.Basking_Shark;
using SpiritMod.Items.Sets.CascadeSet.BubbleMine;
using SpiritMod.Items.Sets.CascadeSet.Reef_Wrath;
using ResonantSouls.SpiritMod.Core;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class CascadeEnchant : BaseEnchant
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Color nameColor => new(204, 217, 233);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.width = 36;
            Item.height = 40;
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
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class CascadeEffect : AccessoryEffect
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Header ToggleHeader => Header.GetHeader<AtlantisHeader>();
        public override int ToggleItemType => ModContent.ItemType<CascadeEnchant>();
    }
}