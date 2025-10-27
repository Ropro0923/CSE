using SpiritMod.Items.Sets.CryoliteSet;
using SpiritMod.Items.Sets.CryoliteSet.CryoliteArmor;
using SpiritMod.Items.Sets.CryoliteSet.CryoSword;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class CryoliteEnchant : BaseEnchant
    {
        public override Color nameColor => new(98, 193, 198);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.rare = ItemRarityID.Orange;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddEffect<CryoliteEffect>(Item);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<CryoliteHead>()
                .AddIngredient<CryoliteBody>()
                .AddIngredient<CryoliteLegs>()
                .AddIngredient<FrigidEnchant>()
                .AddIngredient<CryoSword>()
                .AddIngredient<CryoStaff>()
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }
        public class CryoliteEffect : AccessoryEffect
        {
            public override Header ToggleHeader => null;
            public override int ToggleItemType => ModContent.ItemType<CryoliteEnchant>();
        }
    }
}