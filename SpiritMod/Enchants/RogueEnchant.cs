using ResonantSouls.SpiritMod.Forces;
using SpiritMod.Items.Accessory;
using SpiritMod.Items.Accessory.Leather;
using SpiritMod.Items.Armor;
using SpiritMod.Items.Weapon.Thrown;
using ResonantSouls.SpiritMod.Core;
using FargowiltasSouls.Content.UI.Elements;
using Luminance.Assets;
using Microsoft.Xna.Framework.Graphics;
using FargowiltasSouls;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class RogueEnchant : BaseEnchant
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Color nameColor => new(216, 175, 113);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.width = 44;
            Item.height = 32;
            Item.rare = ItemRarityID.Blue;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddEffect<RogueEffect>(Item);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<RogueHood>()
                .AddIngredient<RoguePlate>()
                .AddIngredient<RoguePants>()
                .AddIngredient<AssassinMagazine>()
                .AddIngredient<LeatherGlove>()
                .AddIngredient<Kunai_Throwing>(250)
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class RogueEffect : AccessoryEffect
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Header ToggleHeader => Header.GetHeader<AdventuresHeader>();
        public override bool ExtraAttackEffect => true;
        public override int ToggleItemType => ModContent.ItemType<RogueEnchant>();
        int KunaiCharge = 0;
        int KunaiCooldown;
        public override void PostUpdate(Player player)
        {
            KunaiCooldown = player.ForceEffect<RogueEffect>() ? 180 : 360;

            if (KunaiCharge < KunaiCooldown)
                KunaiCharge++;

            if (player.whoAmI == Main.myPlayer)
                CooldownBarManager.Activate("KunaiCooldown", ResonantSoulsUtilities.GetEnchantTexture("RogueEnchant").Value, new(216, 175, 113),
                () => (float)KunaiCharge / KunaiCooldown, activeFunction: player.HasEffect<RogueEffect>, displayAtFull: true);

            if (KunaiCharge >= KunaiCooldown)
            {
                RogueDash(player);
            }
            void RogueDash(Player player)
            {
                //  
            }
        }
    }
}