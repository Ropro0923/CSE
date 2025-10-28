using ResonantSouls.SpiritMod.Forces;
using SpiritMod.Items.Sets.BloodcourtSet;
using SpiritMod.Items.Sets.BloodcourtSet.BloodCourt;
using SpiritMod.Items.Sets.BloodcourtSet.Headsplitter;
using SpiritMod.Items.Sets.BloodcourtSet.Heartstrike;
using ResonantSouls.SpiritMod.Core;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class BloodcourtEnchant : BaseEnchant
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Color nameColor => new(255, 99, 83);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.width = 36;
            Item.height = 40;
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
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class BloodcourtEffect : AccessoryEffect
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Header ToggleHeader => Header.GetHeader<ManaHeader>();
        public override int ToggleItemType => ModContent.ItemType<BloodcourtEnchant>();
    }
}