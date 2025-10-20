using SpiritMod.Items.Accessory;
using SpiritMod.Items.Armor.BotanistSet;
using SpiritMod.Items.Sets.BriarDrops;
using SpiritMod.Items.Sets.ToolsMisc.Evergreen;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class BotanistEnchant : BaseEnchant
    {
        public override Color nameColor => new(206, 182, 95);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.value = 5000 + 5000 + 5000 + 10000 + 28000 + 1000;
            Item.rare = ItemRarityID.White;
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
                .AddIngredient<VitalityStone>()
                .AddIngredient<UnfellerOfEvergreens>()
                .AddIngredient<ReachFishingCatch>()
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