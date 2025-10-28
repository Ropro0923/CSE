using SpiritMod;
using SpiritMod.NPCs.DarkfeatherMage;
using SpiritMod.NPCs.FallenAngel;
using SpiritMod.NPCs.Valkyrie;
using SpiritMod.NPCs.Vulture_Matriarch;
using Terraria.ModLoader.IO;

namespace ResonantSouls.SpiritMod.Core
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class SpiritModConditions : ModSystem
    {
        internal static Condition DefeatedJellyDeluge = new("Defeated the Jelly Deluge", () => MyWorld.downedJellyDeluge);
        internal static Condition DefeatedMysticMoon = new("Defeated the Mystic Moon", () => MyWorld.downedBlueMoon);
        internal static Condition DefeatedTide = new("Defeated the Tide", () => MyWorld.downedTide);
        internal static Condition DefeatedVultureMatriarch = new("Defeated the Vulture Matriarch", () => defeatedVultureMatriarch);
        internal static Condition DefeatedGladeWraith = new("Defeated the Glade Wraith", () => MyWorld.downedGladeWraith);
        internal static Condition DefeatedHauntedTome = new("Defeated the Haunted Tome", () => MyWorld.downedTome);
        internal static Condition DefeatedOccultist = new("Defeated the Occultist", () => MyWorld.downedOccultist);
        internal static Condition DefeatedSnaptrapper = new("Defeated the Snaptrapper", () => MyWorld.downedSnaptrapper);
        internal static Condition DefeatedBeholder = new("Defeated the Beholder", () => MyWorld.downedBeholder);
        internal static Condition DefeatedMechromancer = new("Defeated the Mechromancer", () => MyWorld.downedMechromancer);
        internal static Condition DefeatedValkyrie = new("Defeated the Valkyrie", () => defeatedValkyrie);
        internal static Condition DefeatedFallenAngel = new("Defeated the Fallen Angel", () => defeatedFallenAngel);
        internal static Condition DefeatedDarkfeatherMage = new("Defeated the Darkfeather Mage", () => defeatedDarkfeatherMage);
        internal static bool defeatedVultureMatriarch;
        internal static bool defeatedValkyrie;
        internal static bool defeatedFallenAngel;
        internal static bool defeatedDarkfeatherMage;
        public override void SaveWorldData(TagCompound tag)
        {
            List<string> Downed = [];
            if (defeatedVultureMatriarch)
            {
                Downed.Add("VultureMatriarch");
            }
            if (defeatedValkyrie)
            {
                Downed.Add("Valkyrie");
            }
            if (defeatedFallenAngel)
            {
                Downed.Add("FallenAngel");
            }
            if (defeatedDarkfeatherMage)
            {
                Downed.Add("DarkfeatherMage");
            }
        }
        public override void LoadWorldData(TagCompound tag)
        {
            IList<string> Downed = tag.GetList<string>("Downed");
            defeatedVultureMatriarch = Downed.Contains("VultureMatriarch");
            defeatedValkyrie = Downed.Contains("Valkyrie");
            defeatedFallenAngel = Downed.Contains("FallenAngel");
            defeatedDarkfeatherMage = Downed.Contains("DarkfeatherMage");
        }
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class SpiritModConditionsNPC : GlobalNPC
    {
        public override void OnKill(NPC npc)
        {
            if (npc.type == ModContent.NPCType<Vulture_Matriarch>())
            {
                SpiritModConditions.defeatedVultureMatriarch = true;
            }
            else if (npc.type == ModContent.NPCType<Valkyrie>())
            {
                SpiritModConditions.defeatedValkyrie = true;
            }
            else if (npc.type == ModContent.NPCType<FallenAngel>())
            {
                SpiritModConditions.defeatedFallenAngel = true;
            }
            else if (npc.type == ModContent.NPCType<DarkfeatherMage>())
            {
                SpiritModConditions.defeatedDarkfeatherMage = true;
            }
        }
    }
}