using SpiritMod.Items.Sets.FloatingItems.Driftwood;
using SpiritMod.Items.Sets.FloatingItems.Driftwood.DriftwoodArmor;
using SpiritMod.Items.Sets.SummonsMisc.FairyWhistle;
using SpiritMod.Items.Weapon.Summon.ButterflyStaff;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class DriftwoodEnchant : BaseEnchant
    {
        public override Color nameColor => new(186, 154, 114);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.rare = ItemRarityID.White;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddEffect<DriftwoodEffect>(Item);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<DriftwoodHelmet>()
                .AddIngredient<DriftwoodChestplate>()
                .AddIngredient<DriftwoodLeggings>()
                .AddIngredient<ButterflyStaff>()
                .AddIngredient<FairyWhistleItem>()
                .AddIngredient<DriftwoodSword>()
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }
        public class DriftwoodEffect : AccessoryEffect
        {
            public override Header ToggleHeader => null;
            public override int ToggleItemType => ModContent.ItemType<DriftwoodEnchant>();
        }
    }
}