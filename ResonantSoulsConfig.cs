using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace ResonantSouls
{
    public class ResonantSoulsConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;
        internal static ResonantSoulsConfig Instance;
        public override void OnLoaded() => Instance = this;
        public override void OnChanged() => Instance = this;
        [Header("Enchantments")]
        [ReloadRequired]
        [DefaultValue(true)]
        public bool SpiritModEnchantments { get; set; }
    }
}