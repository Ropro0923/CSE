using ResonantSouls.SpiritMod.Forces;
using SpiritMod.Items.Armor.WayfarerSet;
using SpiritMod.Items.Weapon.Swung.Punching_Bag;
using SpiritMod.Items.Placeable.Furniture;
using SpiritMod.Items.Consumable;
using ResonantSouls.SpiritMod.Core;
using FargowiltasSouls.Core.ModPlayers;
using FargowiltasSouls;
using FargowiltasSouls.Content.UI.Elements;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class WayfarerEnchant : BaseEnchant
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Color nameColor => new(169, 127, 110);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.width = 44;
            Item.height = 32;
            Item.rare = ModContent.GetInstance<WayfarerHead>().Item.rare;
            Item.value = ModContent.GetInstance<WayfarerHead>().Item.value + ModContent.GetInstance<WayfarerBody>().Item.value + ModContent.GetInstance<WayfarerLegs>().Item.value + ModContent.GetInstance<ExplorerTreads>().Item.value + ModContent.GetInstance<TechBoots>().Item.value + ModContent.GetInstance<Punching_Bag>().Item.value;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddEffect<WayfarerEffect>(Item);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<WayfarerHead>()
                .AddIngredient<WayfarerBody>()
                .AddIngredient<WayfarerLegs>()
                .AddIngredient<OccultistMap>()
                .AddIngredient<MapScroll>()
                .AddIngredient<Punching_Bag>()
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class WayfarerEffect : AccessoryEffect
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Header ToggleHeader => Header.GetHeader<AdventuresHeader>();
        public override int ToggleItemType => ModContent.ItemType<WayfarerEnchant>();
        int currentCharge = 0;
        int maxCharge;
        public override void PostUpdate(Player player)
        {
            FargoSoulsPlayer modPlayer = player.FargoSouls();
            maxCharge = player.ForceEffect<WayfarerEffect>() ? 5 * 60 : 10 * 60;
            if (modPlayer.WeaponUseTimer > 0 && currentCharge < maxCharge) currentCharge++;
            else if (modPlayer.WeaponUseTimer == 0 && currentCharge > 0) currentCharge--;
            if (player.whoAmI == Main.myPlayer)
                CooldownBarManager.Activate("WayfarerCharge", ResonantSoulsUtilities.GetEnchantTexture("WayfarerEnchant").Value, new(169, 127, 110),
                () => (float)currentCharge / maxCharge, activeFunction: player.HasEffectEnchant<WayfarerEffect>, displayAtFull: true);
        }
        public override void PostUpdateMiscEffects(Player player)
        {
            player.maxRunSpeed *= 1 + (float)currentCharge / maxCharge * (player.ForceEffect<WayfarerEffect>() ? 0.7f : 0.3f);
            player.runAcceleration *= 1 + (float)currentCharge / maxCharge * (player.ForceEffect<WayfarerEffect>() ? 1.1f : 0.7f);
        }
    }
}