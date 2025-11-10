using SpiritMod.Items.Sets.CryoliteSet;
using SpiritMod.Items.Sets.CryoliteSet.CryoliteArmor;
using SpiritMod.Items.Sets.CryoliteSet.CryoSword;
using SpiritMod.Items.Placeable.IceSculpture;
using ResonantSouls.SpiritMod.Forces;
using ResonantSouls.SpiritMod.Core;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class CryoliteEnchant : BaseEnchant
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Color nameColor => new(98, 193, 198);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.width = 36;
            Item.height = 40;
            Item.rare = ModContent.GetInstance<CryoliteHead>().Item.rare;
            Item.value = ModContent.GetInstance<CryoliteHead>().Item.value + ModContent.GetInstance<CryoliteBody>().Item.value + ModContent.GetInstance<CryoliteLegs>().Item.value + ModContent.GetInstance<IceFlinxSculpture>().Item.value + ModContent.GetInstance<CryoSword>().Item.value + ModContent.GetInstance<CryoStaff>().Item.value;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddEffect<CryoliteEffect>(Item);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<CryoliteHead>()
                .AddIngredient<CryoliteBody>()
                .AddIngredient<CryoliteLegs>()
                .AddIngredient<IceFlinxSculpture>()
                .AddIngredient<CryoSword>()
                .AddIngredient<CryoStaff>()
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class CryoliteEffect : AccessoryEffect
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Header ToggleHeader => Header.GetHeader<AtlantisHeader>();
        public override int ToggleItemType => ModContent.ItemType<CryoliteEnchant>();
    }
}
