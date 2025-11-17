using ResonantSouls.SpiritMod.Enchants;

namespace ResonantSouls.SpiritMod.Common
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public static class ResonantSoulsSpiritExtensionMethods
    {
        public static SpiritEffectPlayer SpiritEffectPlayer(this Player player) => player.GetModPlayer<SpiritEffectPlayer>();
    }
}