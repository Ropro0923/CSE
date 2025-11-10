using FargowiltasSouls;
using ResonantSouls.SpiritMod.Buffs;
using ResonantSouls.SpiritMod.Enchants;
using SpiritMod.Items.Sets.MarbleSet.MarbleArmor;
using Terraria.Audio;
using Terraria.DataStructures;

namespace ResonantSouls.SpiritMod.Items
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class AncientRuneCollectible : ModItem
    {
        public override string Texture => "SpiritMod/Items/Sets/RunicSet/Rune";
        public override void SetStaticDefaults()
        {
            Item.rare = ModContent.GetInstance<MarbleHelm>().Item.rare;
            ItemID.Sets.IsAPickup[Type] = true;
            ItemID.Sets.IgnoresEncumberingStone[Type] = true;
            ItemID.Sets.ItemsThatShouldNotBeInInventory[Type] = true;
            ItemID.Sets.ItemNoGravity[Type] = true;
            ItemID.Sets.AnimatesAsSoul[Type] = true;
            ItemID.Sets.ItemIconPulse[Item.type] = true;
            Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(12, 5));
        }
        public override bool OnPickup(Player player)
        {
            SoundEngine.PlaySound(SoundID.Grab, Item.position);
            player.AddBuff(ModContent.BuffType<Gilded>(), 60 * (player.ForceEffect<GildedEffect>() ? 10 : 7));
            return false;
        }
    }
}