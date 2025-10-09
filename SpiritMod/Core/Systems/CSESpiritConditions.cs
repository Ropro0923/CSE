using System.Collections.Generic;
using SpiritMod;
using Terraria.ModLoader.IO;

namespace CSE.SpiritMod.Core.Systems
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class CSESpiritConditions : ModSystem
    {
        internal static Condition DefeatedJellyDeluge = new("Defeated the Jelly Deluge", () => MyWorld.downedJellyDeluge);
        internal static Condition DefeatedMysticMoon = new("Defeated the Mystic Moon", () => MyWorld.downedBlueMoon);
        internal static Condition DefeatedTide = new("Defeated the Tide", () => MyWorld.downedTide);
        internal static Condition DefeatedScarabeus = new("Defeated Scarabeus", () => MyWorld.DownedScarabeus);
        internal static Condition DefeatedVultureMatriarch = new("Defeated the Vulture Matriarch", () => defeatedVultureMatriarch);
        internal static Condition DefeatedMoonJellyWizard = new("Defeated the Moon Jelly Wizard", () => MyWorld.DownedMoonWizard);
        internal static Condition DefeatedVinewraithBane = new("Defeated the Vinewraith Bane", () => MyWorld.DownedVinewrath);
        internal static Condition DefeatedAncientAvian = new("Defeated the Ancient Avian", () => MyWorld.DownedAncientAvian);
        internal static Condition DefeatedStarplateVoyager = new("Defeated the Starplate Voyager", () => MyWorld.DownedStarplate);
        internal static Condition DefeatedInfernon = new("Defeated Infernon", () => MyWorld.DownedInfernon);
        internal static Condition DefeatedDusking = new("Defeated Dusking", () => MyWorld.DownedDusking);
        internal static Condition DefeatedAtlas = new("Defeated Atlas", () => MyWorld.DownedAtlas);
        internal static Condition DefeatedGladeWraith = new("Defeated the Glade Wraith", () => MyWorld.downedGladeWraith);
        internal static Condition DefeatedHauntedTome = new("Defeated the Haunted Tome", () => MyWorld.downedTome);
        internal static Condition DefeatedOccultist = new("Defeated the Occultist", () => MyWorld.downedOccultist);
        internal static Condition DefeatedBeholder = new("Defeated the Beholder", () => MyWorld.downedBeholder);
        internal static Condition DefeatedSnaptrapper = new("Defeated the Snaptrapper", () => MyWorld.downedSnaptrapper);
        internal static Condition DefeatedMechromancer = new("Defeated the Mechromancer", () => MyWorld.downedMechromancer);
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
}