using ResonantSouls.SpiritMod.Forces;
using SpiritMod.Items.Sets.SeraphSet;
using SpiritMod.Items.Sets.SeraphSet.SeraphArmor;
using SpiritMod.Items.BossLoot.MoonWizardDrops.JellynautHelmet;
using SpiritMod.Items.Weapon.Summon;
using ResonantSouls.SpiritMod.Core;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class SeraphEnchant : BaseEnchant
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Color nameColor => new(165, 189, 221);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.width = 36;
            Item.height = 40;
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
                .AddIngredient<JellynautBubble>()
                .AddIngredient<WayfinderTorch>(275)
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class SeraphEffect : AccessoryEffect
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Header ToggleHeader => Header.GetHeader<ManaHeader>();
        public override int ToggleItemType => ModContent.ItemType<SeraphEnchant>();
    }
}