using SpiritMod;
using SpiritMod.NPCs.Vulture_Matriarch;
using Terraria.ModLoader.IO;

namespace SOR.SpiritMod.Core
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class SpiritModConditions : ModSystem
    {
        internal static Condition DefeatedJellyDeluge = new("Defeated the Jelly Deluge", () => MyWorld.downedJellyDeluge);
        internal static Condition DefeatedMysticMoon = new("Defeated the Mystic Moon", () => MyWorld.downedBlueMoon);
        internal static Condition DefeatedTide = new("Defeated the Tide", () => MyWorld.downedTide);
        internal static bool defeatedVultureMatriarch;
        public override void SaveWorldData(TagCompound tag)
        {
            List<string> Downed = [];
            if (defeatedVultureMatriarch)
            {
                Downed.Add("VultureMatriarch");
            }
        }
        public override void LoadWorldData(TagCompound tag)
        {
            IList<string> Downed = tag.GetList<string>("Downed");
            defeatedVultureMatriarch = Downed.Contains("VultureMatriarch");
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
        }
    }
}