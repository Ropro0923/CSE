using Fargowiltas.Content.Items.Summons;
using ResonantSouls.SpiritMod.Core;
using SpiritMod.NPCs.Beholder;
using SpiritMod.NPCs.Boss.FrostTroll;
using SpiritMod.NPCs.Boss.Occultist;
using SpiritMod.NPCs.DarkfeatherMage;
using SpiritMod.NPCs.FallenAngel;
using SpiritMod.NPCs.GladiatorSpirit;
using SpiritMod.NPCs.HauntedTome;
using SpiritMod.NPCs.Mechromancer;
using SpiritMod.NPCs.Reach;
using SpiritMod.NPCs.Snaptrapper;
using SpiritMod.NPCs.Tides;
using SpiritMod.NPCs.Valkyrie;
using SpiritMod.NPCs.Vulture_Matriarch;

namespace ResonantSouls.SpiritMod.QOL
{
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    public class AncientTentacle : BaseSummon
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.QualityOfLife;
        public override string Texture => $"{Mod.Name}/Assets/Textures/Content/Items/Consumables/Summons/{Name}";
        public override int NPCType => ModContent.NPCType<Rylheian>();
    }
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    public class AvianCrown : BaseSummon
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.QualityOfLife;
        public override string Texture => $"{Mod.Name}/Assets/Textures/Content/Items/Consumables/Summons/{Name}";
        public override int NPCType => ModContent.NPCType<Vulture_Matriarch>();
    }
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    public class BrightFeather : BaseSummon
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.QualityOfLife;
        public override string Texture => $"{Mod.Name}/Assets/Textures/Content/Items/Consumables/Summons/{Name}";
        public override int NPCType => ModContent.NPCType<Valkyrie>();
    }
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    public class BrokenHalo : BaseSummon
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.QualityOfLife;
        public override string Texture => $"{Mod.Name}/Assets/Textures/Content/Items/Consumables/Summons/{Name}";
        public override int NPCType => ModContent.NPCType<FallenAngel>();
    }
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    public class CloakedHat : BaseSummon
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.QualityOfLife;
        public override string Texture => $"{Mod.Name}/Assets/Textures/Content/Items/Consumables/Summons/{Name}";
        public override int NPCType => ModContent.NPCType<DarkfeatherMage>();
    }
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    public class FrostLantern : BaseSummon
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.QualityOfLife;
        public override string Texture => $"{Mod.Name}/Assets/Textures/Content/Items/Consumables/Summons/{Name}";
        public override int NPCType => ModContent.NPCType<FrostSaucer>();
    }
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    public class GladeLeaves : BaseSummon
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.QualityOfLife;
        public override string Texture => $"{Mod.Name}/Assets/Textures/Content/Items/Consumables/Summons/{Name}";
        public override int NPCType => ModContent.NPCType<ForestWraith>();
    }
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    public class GladiatorsCloak : BaseSummon
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.QualityOfLife;
        public override string Texture => $"{Mod.Name}/Assets/Textures/Content/Items/Consumables/Summons/{Name}";
        public override int NPCType => ModContent.NPCType<GladiatorSpirit>();
    }
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    public class HauntedPage : BaseSummon
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.QualityOfLife;
        public override string Texture => $"{Mod.Name}/Assets/Textures/Content/Items/Consumables/Summons/{Name}";
        public override int NPCType => ModContent.NPCType<HauntedTome>();
    }
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    public class MarbleEye : BaseSummon
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.QualityOfLife;
        public override string Texture => $"{Mod.Name}/Assets/Textures/Content/Items/Consumables/Summons/{Name}";
        public override int NPCType => ModContent.NPCType<Beholder>();
    }
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    public class MechanicalOrb : BaseSummon
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.QualityOfLife;
        public override string Texture => $"{Mod.Name}/Assets/Textures/Content/Items/Consumables/Summons/{Name}";
        public override int NPCType => ModContent.NPCType<Mecromancer>();
    }
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    public class OccultistsRobe : BaseSummon
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.QualityOfLife;
        public override string Texture => $"{Mod.Name}/Assets/Textures/Content/Items/Consumables/Summons/{Name}";
        public override int NPCType => ModContent.NPCType<OccultistBoss>();
    }
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    public class SporePouch : BaseSummon
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.QualityOfLife;
        public override string Texture => $"{Mod.Name}/Assets/Textures/Content/Items/Consumables/Summons/{Name}";
        public override int NPCType => ModContent.NPCType<Snaptrapper>();
    }
}