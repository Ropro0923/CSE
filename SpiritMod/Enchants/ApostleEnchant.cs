using ResonantSouls.SpiritMod.Core;
using ResonantSouls.SpiritMod.Forces;
using SpiritMod.Items.BossLoot.AvianDrops;
using SpiritMod.Items.BossLoot.AvianDrops.ApostleArmor;
using SpiritMod.Items.Weapon.Magic;
using SpiritMod.Items.Sets.BowsMisc.StarSpray;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class ApostleEnchant : BaseEnchant
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Color nameColor => new(227, 216, 175);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.width = 44;
            Item.height = 48;
            Item.rare = ModContent.GetInstance<TalonHeaddress>().Item.rare;
            Item.value = ModContent.GetInstance<TalonHeaddress>().Item.value + ModContent.GetInstance<TalonGarb>().Item.value + ModContent.GetInstance<SkeletalonStaff>().Item.value + ModContent.GetInstance<SoaringScapula>().Item.value + ModContent.GetInstance<TalonPiercer>().Item.value;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddEffect<ApostleEffect>(Item);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<TalonHeaddress>()
                .AddIngredient<TalonGarb>()
                .AddIngredient<ValkyrieSpear>()
                .AddIngredient<StarlightBow>()
                .AddIngredient<TalonPiercer>()
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class ApostleEffect : AccessoryEffect
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Header ToggleHeader => Header.GetHeader<FoesHeader>();
        public override int ToggleItemType => ModContent.ItemType<ApostleEnchant>();
    }
}