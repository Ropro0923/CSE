using ResonantSouls.SpiritMod.Core;
using ResonantSouls.SpiritMod.Forces;
using SpiritMod.Items.Sets.ClubSubclass;
using SpiritMod.Items.Sets.GraniteSet;
using SpiritMod.Items.Sets.GraniteSet.GraniteArmor;
using SpiritMod.Items.Sets.GraniteSet.GraniteFlail;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class GraniteEnchant : BaseEnchant
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Color nameColor => new(100, 143, 246);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.width = 36;
            Item.height = 40;
            Item.rare = ModContent.GetInstance<GraniteHelm>().Item.rare;
            Item.value = ModContent.GetInstance<GraniteHelm>().Item.value + ModContent.GetInstance<GraniteChest>().Item.value + ModContent.GetInstance<GraniteLegs>().Item.value + ModContent.GetInstance<RageBlazeDecapitator>().Item.value + ModContent.GetInstance<GraniteBow>().Item.value + ModContent.GetInstance<GraniteFlail>().Item.value;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddEffect<GraniteEffect>(Item);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<GraniteHelm>()
                .AddIngredient<GraniteChest>()
                .AddIngredient<GraniteLegs>()
                .AddIngredient<RageBlazeDecapitator>()
                .AddIngredient<GraniteBow>()
                .AddIngredient<GraniteFlail>()
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class GraniteEffect : AccessoryEffect
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Header ToggleHeader => Header.GetHeader<WorldsHeader>();
        public override int ToggleItemType => ModContent.ItemType<GraniteEnchant>();
    }
}