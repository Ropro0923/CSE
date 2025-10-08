using SpiritMod.NPCs.Town;

namespace CSE.SpiritMod
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class SpiritModCaughtNPCs : ModSystem
    {
        public static void RegisterSpiritModCaughtNPCs()
        {
            CSE.Add("Adventurer", ModContent.NPCType<Adventurer>());
            CSE.Add("Gambler", ModContent.NPCType<Gambler>());
            CSE.Add("Rogue", ModContent.NPCType<Rogue>());
            CSE.Add("Rune Wizard", ModContent.NPCType<RuneWizard>());
        }
    }
}
