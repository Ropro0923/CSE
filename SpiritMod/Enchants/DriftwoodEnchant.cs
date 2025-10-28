using SpiritMod.Items.Sets.FloatingItems.Driftwood;
using SpiritMod.Items.Sets.FloatingItems.Driftwood.DriftwoodArmor;
using SpiritMod.Items.Sets.CascadeSet.Coral_Catcher;
using SpiritMod.Items.Weapon.Summon.ButterflyStaff;
using FargowiltasSouls.Core.Toggler.Content;
using ResonantSouls.SpiritMod.Core;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class DriftwoodEnchant : BaseEnchant
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Color nameColor => new(186, 154, 114);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.width = 40;
            Item.height = 40;
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
                .AddIngredient<Coral_Catcher>()
                .AddIngredient<DriftwoodSword>()
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class DriftwoodEffect : AccessoryEffect
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Header ToggleHeader => Header.GetHeader<TrawlerHeader>();
        public override int ToggleItemType => ModContent.ItemType<DriftwoodEnchant>();
    }
}