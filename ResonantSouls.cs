
global using Terraria;
global using Terraria.ModLoader;
global using Terraria.ID;
global using Microsoft.Xna.Framework;
global using static System.MathF;
global using static Microsoft.Xna.Framework.MathHelper;
global using FargowiltasSouls.Core.Toggler;
global using ResonantSouls.Core;
global using System;
global using FargowiltasSouls.Content.Items.Accessories.Enchantments;
global using FargowiltasSouls.Core.AccessoryEffectSystem;
global using System.Collections.Generic;
global using Fargowiltas.Content.Items.Tiles;
using Fargowiltas.Common.Configs;
using ResonantSouls.SpiritMod.QOL;

namespace ResonantSouls
{
	public class ResonantSouls : Mod
	{
		internal static ResonantSouls Instance;
		public override void Load()
		{
			Instance = this;
			if (FargoServerConfig.Instance.CatchNPCs)
			{
				if (ModCompatibility.SpiritMod.Loaded)
					SpiritModCaughtNPCs.RegisterSpiritModCaughtNPCs();
			}
			EnchantedTreeTileEntity.SoulsMods.Add(Instance.Name);
		}
		public override void Unload()
		{
			Instance = null;
		}
	}
}
