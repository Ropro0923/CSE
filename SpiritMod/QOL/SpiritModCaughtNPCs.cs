using SpiritMod.NPCs.Town;
using SpiritMod.NPCs.Town.Oracle;

namespace ResonantSouls.SpiritMod.QOL
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class SpiritModCaughtNPCs
    {
        public static void RegisterSpiritModCaughtNPCs()
        {
            ModCompatibility.Fargowiltas.Mod.Call("AddCaughtNPC", "Adventurer", ModContent.NPCType<Adventurer>(), ResonantSouls.Instance.Name);
            ModCompatibility.Fargowiltas.Mod.Call("AddCaughtNPC", "Gambler", ModContent.NPCType<Gambler>(), ResonantSouls.Instance.Name);
            ModCompatibility.Fargowiltas.Mod.Call("AddCaughtNPC", "Bandit", ModContent.NPCType<Rogue>(), ResonantSouls.Instance.Name);
            ModCompatibility.Fargowiltas.Mod.Call("AddCaughtNPC", "RuneWizard", ModContent.NPCType<RuneWizard>(), ResonantSouls.Instance.Name);
            ModCompatibility.Fargowiltas.Mod.Call("AddCaughtNPC", "Oracle", ModContent.NPCType<Oracle>(), ResonantSouls.Instance.Name);
        }
    }
}