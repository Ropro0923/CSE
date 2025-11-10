using ResonantSouls.SpiritMod.Forces;
using SpiritMod.Items.Sets.SwordsMisc.EternalSwordTree;
using SpiritMod.Items.BossLoot.AtlasDrops;
using SpiritMod.Items.BossLoot.InfernonDrops;
using SpiritMod.Items.BossLoot.DuskingDrops;
using SpiritMod.Items.BossLoot.AtlasDrops.PrimalstoneArmor;
using ResonantSouls.SpiritMod.Core;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class PrimalstoneEnchant : BaseEnchant
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Color nameColor => new(164, 193, 176);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.width = 40;
            Item.height = 46;
            Item.rare = ModContent.GetInstance<PrimalstoneFaceplate>().Item.rare;
            Item.value = ModContent.GetInstance<PrimalstoneFaceplate>().Item.value + ModContent.GetInstance<PrimalstoneBreastplate>().Item.value + ModContent.GetInstance<PrimalstoneLeggings>().Item.value + ModContent.GetInstance<DemoncomboSword>().Item.value + ModContent.GetInstance<InfernalSword>().Item.value + ModContent.GetInstance<ShadowSphere>().Item.value;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddEffect<PrimalstoneEffect>(Item);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<PrimalstoneFaceplate>()
                .AddIngredient<PrimalstoneBreastplate>()
                .AddIngredient<PrimalstoneLeggings>()
                .AddIngredient<DemoncomboSword>()
                .AddIngredient<InfernalSword>()
                .AddIngredient<ShadowSphere>()
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class PrimalstoneEffect : AccessoryEffect
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Header ToggleHeader => Header.GetHeader<FoesHeader>();
        public override int ToggleItemType => ModContent.ItemType<PrimalstoneEnchant>();
    }
}