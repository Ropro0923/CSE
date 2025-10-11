using Fargowiltas.Content.Items.Tiles;
using SpiritMod.Items.ByBiome.Briar.Consumables;
using SpiritMod.Items.Consumable;
using SpiritMod.Items.Sets.HuskstalkSet;
using SpiritMod.Items.Sets.HuskstalkSet.ElderbarkArmor;

namespace SOR.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class ElderbarkEnchant : BaseEnchant
    {
        public override string Texture => $"{Mod.Name}/SpiritMod/Enchants/ElderbarkEnchant";
        public override bool IsLoadingEnabled(Mod mod) => SORConfig.Instance.SpiritMod;
        public override Color nameColor => new(154, 181, 90);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.rare = ItemRarityID.Blue;  
            Item.value = Item.sellPrice(silver: 18, copper: 50);
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddEffect<ElderbarkEffect>(Item);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<ElderbarkHead>()
                .AddIngredient<ElderbarkChest>()
                .AddIngredient<ElderbarkLegs>()
                .AddIngredient<HuskstalkSword>()
                .AddIngredient<BriarmothItem>()
                .AddIngredient<Durian>()
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }
        public class ElderbarkEffect : AccessoryEffect
        {
            public override Header ToggleHeader => null;
            public override int ToggleItemType => ModContent.ItemType<ElderbarkEnchant>();
        } 
    }
}
