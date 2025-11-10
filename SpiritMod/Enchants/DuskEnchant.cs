using ResonantSouls.SpiritMod.Forces;
using SpiritMod.Items.BossLoot.DuskingDrops;
using SpiritMod.Items.BossLoot.DuskingDrops.DuskArmor;
using SpiritMod.Items.DonatorItems;
using SpiritMod.Items.Sets.SlingHammerSubclass;
using ResonantSouls.SpiritMod.Core;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class DuskEnchant : BaseEnchant
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Color nameColor => new(164, 122, 255);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.width = 56;
            Item.height = 50;
            Item.rare = ModContent.GetInstance<DuskHood>().Item.rare;
            Item.value = ModContent.GetInstance<DuskHood>().Item.value + ModContent.GetInstance<DuskPlate>().Item.value + ModContent.GetInstance<DuskLeggings>().Item.value + ModContent.GetInstance<BladeofYouKai>().Item.value + ModContent.GetInstance<Shadowmoor>().Item.value + ModContent.GetInstance<UmbraStaff>().Item.value;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddEffect<DuskEffect>(Item);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<DuskHood>()
                .AddIngredient<DuskPlate>()
                .AddIngredient<DuskLeggings>()
                .AddIngredient<BladeofYouKai>()
                .AddIngredient<Shadowmoor>()
                .AddIngredient<PossessedHammer>()
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class DuskEffect : AccessoryEffect
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Header ToggleHeader => Header.GetHeader<FoesHeader>();
        public override int ToggleItemType => ModContent.ItemType<DuskEnchant>();
    }
}