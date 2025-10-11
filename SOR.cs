
global using Terraria;
global using Terraria.ModLoader;
global using Terraria.ID;
global using Microsoft.Xna.Framework;
global using static System.MathF;
global using static Microsoft.Xna.Framework.MathHelper;
global using FargowiltasSouls.Core.Toggler;
global using SOR.Core;
global using System;
global using FargowiltasSouls.Content.Items.Accessories.Enchantments;
global using FargowiltasSouls.Core.AccessoryEffectSystem;
using Fargowiltas.Common.Configs;
using SOR.SpiritMod.QOL;

namespace SOR
{
	public class SOR : Mod
	{
		internal static SOR Instance;
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
