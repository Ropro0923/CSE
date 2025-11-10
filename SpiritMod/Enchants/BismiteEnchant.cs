using ResonantSouls.SpiritMod.Core;
using ResonantSouls.SpiritMod.Forces;
using SpiritMod.Items.Accessory.Leather;
using SpiritMod.Items.Sets.BismiteSet;
using SpiritMod.Items.Sets.BismiteSet.BismiteArmor;
using SpiritMod.Items.Sets.SepulchreLoot.AccursedBlade;
using SpiritMod.Items.Consumable.Potion;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class BismiteEnchant : BaseEnchant
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Color nameColor => new(164, 202, 74);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.width = 36;
            Item.height = 40;
            Item.rare = ModContent.GetInstance<BismiteHelmet>().Item.rare;
            Item.value = ModContent.GetInstance<BismiteHelmet>().Item.value + ModContent.GetInstance<BismiteChestplate>().Item.value + ModContent.GetInstance<BismiteLeggings>().Item.value + ModContent.GetInstance<BismiteShield>().Item.value + ModContent.GetInstance<BismiteChakra>().Item.value + ModContent.GetInstance<BismiteStaff>().Item.value;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddEffect<BismiteEffect>(Item);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<BismiteHelmet>()
                .AddIngredient<BismiteChestplate>()
                .AddIngredient<BismiteLeggings>()
                .AddIngredient<BismitePotion>(3)
                .AddIngredient<BismiteChakra>()
                .AddIngredient<AccursedBlade>()
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }

    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class BismiteEffect : AccessoryEffect
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Header ToggleHeader => Header.GetHeader<WorldsHeader>();
        public override int ToggleItemType => ModContent.ItemType<BismiteEnchant>();
    }
}