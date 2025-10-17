using SpiritMod.Items.BossLoot.StarplateDrops;
using SpiritMod.Items.BossLoot.StarplateDrops.StarArmor;
using SpiritMod.Items.BossLoot.StarplateDrops.StarplateGlove;
using SpiritMod.Items.Sets.SwordsMisc.AlphaBladeTree;

namespace SOR.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class AstraliteEnchant : BaseEnchant
    {
        public override Color nameColor => new(234, 197, 128);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.value = 15000 + 19000 + 17500 + 100000 + 100000 + 27500;
            Item.rare = ItemRarityID.Orange;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddEffect<AstraliteEffect>(Item);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<StarMask>()
                .AddIngredient<StarPlate>()
                .AddIngredient<StarLegs>()
                .AddIngredient<Starblade>()
                .AddIngredient<OrionPistol>()
                .AddIngredient<StarplateGlove>()
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }
        public class AstraliteEffect : AccessoryEffect
        {
            public override Header ToggleHeader => null;
            public override int ToggleItemType => ModContent.ItemType<AstraliteEnchant>();
        }
    }
}