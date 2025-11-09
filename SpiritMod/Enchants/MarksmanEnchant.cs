using ResonantSouls.SpiritMod.Forces;
using SpiritMod.Items.Accessory.Leather;
using SpiritMod.Items.Armor.LeatherArmor;
using SpiritMod.Items.DonatorItems;
using SpiritMod.Items.Sets.HusktalkSet.;
using SpiritMod.Items.Ammo.Arrow;
using ResonantSouls.SpiritMod.Core;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class MarksmanEnchant : BaseEnchant
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Color nameColor => new(134, 94, 64);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.width = 44;
            Item.height = 32;
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
                .AddIngredient<HuskstalkBow>()
                .AddIngredient<SepulchreArrow>(50)
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class MarksmanEffect : AccessoryEffect
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Header ToggleHeader => Header.GetHeader<AdventuresHeader>();
        public override int ToggleItemType => ModContent.ItemType<MarksmanEnchant>();
    }
}