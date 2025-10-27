using SpiritMod.Items.Sets.ClubSubclass;
using SpiritMod.Items.Sets.GraniteSet;
using SpiritMod.Items.Sets.GraniteSet.GraniteArmor;
using SpiritMod.Items.Sets.GraniteSet.GraniteFlail;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class GraniteEnchant : BaseEnchant
    {
        public override Color nameColor => new(100, 143, 246);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.rare = ItemRarityID.Green;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddEffect<GraniteEffect>(Item);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<GraniteHelm>()
                .AddIngredient<GraniteChest>()
                .AddIngredient<GraniteLegs>()
                .AddIngredient<RageBlazeDecapitator>()
                .AddIngredient<GraniteBow>()
                .AddIngredient<GraniteFlail>()
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }
        public class GraniteEffect : AccessoryEffect
        {
            public override Header ToggleHeader => null;
            public override int ToggleItemType => ModContent.ItemType<GraniteEnchant>();
        }
    }
}