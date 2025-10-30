using SpiritMod.NPCs.Town;
using SpiritMod.NPCs.Town.Oracle;
using ResonantSouls.SpiritMod.Core;
using Fargowiltas.Common.Configs;

namespace ResonantSouls.SpiritMod.QOL
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class SpiritModCaughtNPCs : ModSystem
    {
        public override bool IsLoadingEnabled(Mod mod) => FargoServerConfig.Instance.CatchNPCs && ResonantSoulsSpiritConfig.Instance.QualityOfLife;
        public override void Load()
        {
            Mod Fargowiltas = ModCompatibility.Fargowiltas.Mod;

            Fargowiltas.Call("AddCaughtNPC", "Adventurer", ModContent.NPCType<Adventurer>(), Mod.Name);
            Fargowiltas.Call("AddCaughtNPC", "Gambler", ModContent.NPCType<Gambler>(), Mod.Name);
            Fargowiltas.Call("AddCaughtNPC", "Bandit", ModContent.NPCType<Rogue>(), Mod.Name);
            Fargowiltas.Call("AddCaughtNPC", "Enchanter", ModContent.NPCType<RuneWizard>(), Mod.Name);
            Fargowiltas.Call("AddCaughtNPC", "Oracle", ModContent.NPCType<Oracle>(), Mod.Name);
        }
    }
}