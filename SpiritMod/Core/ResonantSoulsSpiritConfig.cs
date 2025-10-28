using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace ResonantSouls.SpiritMod.Core
{
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    public class ResonantSoulsSpiritConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;
        internal static ResonantSoulsSpiritConfig Instance;
        public override void OnChanged() => Instance = this;
        public override void OnLoaded() => Instance = this;

        [Header("LoadedContent")]

        [ReloadRequired]
        [DefaultValue(true)]
        public bool Enchantments { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool EternityModeAccessories { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool Energizers { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool QualityOfLife { get; set; }
    }
}