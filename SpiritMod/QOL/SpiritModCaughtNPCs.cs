using SpiritMod.NPCs.Town;
using SpiritMod.NPCs.Town.Oracle;
using ResonantSouls.SpiritMod.Core;

namespace ResonantSouls.SpiritMod.QOL
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class SpiritModCaughtNPCs : ModSystem
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.QualityOfLife;
        public static void RegisterSpiritModCaughtNPCs()
        {
            ModCompatibility.Fargowiltas.Mod.Call("AddCaughtNPC", "Adventurer", ModContent.NPCType<Adventurer>(), ResonantSouls.Instance.Name);
            ModCompatibility.Fargowiltas.Mod.Call("AddCaughtNPC", "Gambler", ModContent.NPCType<Gambler>(), ResonantSouls.Instance.Name);
            ModCompatibility.Fargowiltas.Mod.Call("AddCaughtNPC", "Bandit", ModContent.NPCType<Rogue>(), ResonantSouls.Instance.Name);
            ModCompatibility.Fargowiltas.Mod.Call("AddCaughtNPC", "Enchanter", ModContent.NPCType<RuneWizard>(), ResonantSouls.Instance.Name);
            ModCompatibility.Fargowiltas.Mod.Call("AddCaughtNPC", "Oracle", ModContent.NPCType<Oracle>(), ResonantSouls.Instance.Name);
        }
    }
}