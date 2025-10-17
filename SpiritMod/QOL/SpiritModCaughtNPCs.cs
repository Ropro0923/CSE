using SpiritMod.NPCs.Town;
using SpiritMod.NPCs.Town.Oracle;

namespace SOR.SpiritMod.QOL
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class SpiritModCaughtNPCs
    {
        public static void RegisterSpiritModCaughtNPCs()
        {
            ModCompatibility.Fargowiltas.Mod.Call("AddCaughtNPC", "Adventurer", ModContent.NPCType<Adventurer>(), SOR.Instance.Name);
            ModCompatibility.Fargowiltas.Mod.Call("AddCaughtNPC", "Gambler", ModContent.NPCType<Gambler>(), SOR.Instance.Name);
            ModCompatibility.Fargowiltas.Mod.Call("AddCaughtNPC", "Bandit", ModContent.NPCType<Rogue>(), SOR.Instance.Name);
            ModCompatibility.Fargowiltas.Mod.Call("AddCaughtNPC", "RuneWizard", ModContent.NPCType<RuneWizard>(), SOR.Instance.Name);
            ModCompatibility.Fargowiltas.Mod.Call("AddCaughtNPC", "Oracle", ModContent.NPCType<Oracle>(), SOR.Instance.Name);
        }
    }
}