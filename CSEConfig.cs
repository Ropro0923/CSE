using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace CSE
{
    public class CSEConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;
        internal static CSEConfig Instance;
        public override void OnLoaded() => Instance = this;
        public override void OnChanged() => Instance = this;

        [Header("Enchantments")]

        [ReloadRequired]
        [DefaultValue(true)]
        public bool SpiritMod { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool SpiritReforged { get; set; }
    }
}