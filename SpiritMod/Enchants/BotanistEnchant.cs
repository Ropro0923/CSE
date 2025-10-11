using Fargowiltas.Content.Items.Tiles;
using SpiritMod.Items.Armor.BotanistSet;
using SpiritMod.Items.ByBiome.Briar.Consumables;
using SpiritMod.Items.Consumable;
using SpiritMod.Items.Placeable.Furniture;
using SpiritMod.Items.Sets.BriarChestLoot;
using SpiritMod.Items.Sets.FloranSet;
using SpiritMod.Items.Sets.HuskstalkSet;
using SpiritMod.Items.Sets.HuskstalkSet.ElderbarkArmor;

namespace SOR.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class BotanistEnchant : BaseEnchant
    {
        public override string Texture => $"{Mod.Name}/SpiritMod/Enchants/BotanistEnchant";
        public override bool IsLoadingEnabled(Mod mod) => SORConfig.Instance.SpiritMod;
        public override Color nameColor => new(241, 234, 164);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.rare = ItemRarityID.Blue;  
            Item.value = Item.sellPrice(silver: 18, copper: 50);
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddEffect<BotanistEffect>(Item);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<BotanistHat>()
                .AddIngredient<BotanistBody>()
                .AddIngredient<BotanistLegs>()
                .AddIngredient<FloranCharm>()
                .AddIngredient<ForagerTableItem>()
                .AddIngredient<SunPot>(5)
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }
        public class BotanistEffect : AccessoryEffect
        {
            public override Header ToggleHeader => null;
            public override int ToggleItemType => ModContent.ItemType<BotanistEnchant>();
        } 
    }
}
