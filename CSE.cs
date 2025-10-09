
global using Terraria;
global using Terraria.ModLoader;
global using Terraria.ID;
global using Microsoft.Xna.Framework;
global using static System.MathF;
global using static Microsoft.Xna.Framework.MathHelper;
global using FargowiltasSouls.Core.Toggler;
global using CSE.Core;
using SpiritMod.NPCs.Town;
using Fargowiltas.Common.Configs;
using CSE.SpiritMod;

namespace CSE
{
	public class CSE : Mod
	{
		internal static CSE Instance;
		public override void Load()
		{
			Instance = this;
			if (FargoServerConfig.Instance.CatchNPCs)
            {
                if (ModCompatibility.SpiritMod.Loaded)
					SpiritModCaughtNPCs.RegisterSpiritModCaughtNPCs();
            }
		}
        public override void Unload()
		{
			Instance = null;
		}
	}
}
