
global using Terraria;
global using Terraria.ModLoader;
global using Terraria.ID;
global using System;
global using Microsoft.Xna.Framework;
global using static System.MathF;
global using static Microsoft.Xna.Framework.MathHelper;
global using FargowiltasSouls.Content.Items.Accessories.Enchantments;
global using FargowiltasSouls.Core.AccessoryEffectSystem;
global using FargowiltasSouls.Core.Toggler;
global using CSE.Core;
using Fargowiltas.Items.CaughtNPCs;
using System.Collections.Generic;
using Luminance.Common.Utilities;
using System.Reflection;
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
				{
					SpiritModCaughtNPCs.RegisterSpiritModCaughtNPCs();
				}
			}
		}
        public override void Unload()
		{
			Instance = null;
		}
        public static void Add(string internalName, int id)
		{
			CaughtNPCItem item = new(internalName, id);
			Instance.AddContent(item);
			FieldInfo info = typeof(CaughtNPCItem).GetField("CaughtTownies", Utilities.UniversalBindingFlags);
			Dictionary<int, int> list = (Dictionary<int, int>)info.GetValue(info);
			list.Add(id, item.Type);
			info.SetValue(info, list);
		}
	}
}
