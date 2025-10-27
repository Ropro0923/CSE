using SpiritMod.Items.Sets.SeraphSet;
using SpiritMod.Items.Sets.SeraphSet.SeraphArmor;
using SpiritMod.Items.Weapon.Summon;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class SeraphEnchant : BaseEnchant
    {
        public override Color nameColor => new(165, 189, 221);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.rare = ItemRarityID.LightRed;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddEffect<SeraphEffect>(Item);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<SeraphHelm>()
                .AddIngredient<SeraphArmor>()
                .AddIngredient<SeraphLegs>()
                .AddIngredient<GloomgusStaff>()
                .AddIngredient<GlowSting>()
                .AddIngredient<WayfinderTorch>()
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }
        public class SeraphEffect : AccessoryEffect
        {
            public override Header ToggleHeader => null;
            public override int ToggleItemType => ModContent.ItemType<SeraphEnchant>();
        }
    }
}