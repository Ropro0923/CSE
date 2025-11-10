using ResonantSouls.SpiritMod.Forces;
using SpiritMod.Items.Sets.ReefhunterSet;
using SpiritMod.Items.Sets.TideDrops;
using SpiritMod.Items.Sets.TideDrops.StreamSurfer;
using ResonantSouls.SpiritMod.Core;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class StreamSurferEnchant : BaseEnchant
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Color nameColor => new(114, 212, 230);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.width = 36;
            Item.height = 40;
            Item.rare = ModContent.GetInstance<StreamSurferHelmet>().Item.rare;
            Item.value = ModContent.GetInstance<StreamSurferHelmet>().Item.value + ModContent.GetInstance<StreamSurferChestplate>().Item.value + ModContent.GetInstance<StreamSurferLeggings>().Item.value + ModContent.GetInstance<CoconutGun>().Item.value + ModContent.GetInstance<PendantOfTheOcean>().Item.value + ModContent.GetInstance<Minifish>().Item.value;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddEffect<StreamSurferEffect>(Item);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<StreamSurferHelmet>()
                .AddIngredient<StreamSurferChestplate>()
                .AddIngredient<StreamSurferLeggings>()
                .AddIngredient<CoconutGun>()
                .AddIngredient<PendantOfTheOcean>()
                .AddIngredient<Minifish>()
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class StreamSurferEffect : AccessoryEffect
    {
        public override Header ToggleHeader => Header.GetHeader<AtlantisHeader>();
        public override int ToggleItemType => ModContent.ItemType<StreamSurferEnchant>();
    }
}
