using FargowiltasSouls;
using ResonantSouls.SpiritMod.Core;
using ResonantSouls.SpiritMod.Enchants;

namespace ResonantSouls.SpiritMod.Buffs
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class Gilded : ModBuff
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override string Texture => "FargowiltasSouls/Assets/Textures/Content/Buffs/buffTemplate";
        public override void SetStaticDefaults()
        {
            Main.buffNoSave[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
        //    player.moveSpeed += player.ForceEffect<GildedEffect>() ? 0.15f : 0.10f;
        //    player.wingTimeMax += 250;
        //    Main.NewText($"Max: {player.wingTimeMax}");
        //    Main.NewText($"Current: {player.wingTime}");
        }
    }
}