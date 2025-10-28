using FargowiltasSouls;
using FargowiltasSouls.Core.Globals;
using FargowiltasSouls.Core.NPCMatching;
using SpiritMod;
using SpiritMod.Items.Consumable;
using SpiritMod.NPCs.Boss;
using SpiritMod.NPCs.Boss.MoonWizard;
using SpiritMod.NPCs.Boss.ReachBoss;
using SpiritMod.NPCs.Boss.Scarabeus;
using SpiritMod.NPCs.Boss.SteamRaider;
using ResonantSouls.SpiritMod.Core;

namespace ResonantSouls.SpiritMod.QOL
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class SpiritModBossSummonOnSpawn : ModSystem
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.QualityOfLife;
        public class AncientAvian : EModeNPCBehaviour
        {
            public override NPCMatcher CreateMatcher() => new NPCMatcher().MatchType(ModContent.NPCType<AncientFlyer>());
            public bool DroppedSummon;
            public override bool SafePreAI(NPC npc)
            {
                if (npc.HasPlayerTarget && !DroppedSummon && npc.boss)
                {
                    Player player = Main.player[npc.target];

                    if (!player.dead)
                    {
                        if (!MyWorld.DownedMoonWizard && FargoSoulsUtil.HostCheck)
                        {
                            Item.NewItem(npc.GetSource_Loot(), player.Hitbox, ModContent.ItemType<JewelCrown>());
                        }
                        DroppedSummon = true;
                    }
                }
                return true;
            }
        }
        public class Atlas : EModeNPCBehaviour
        {
            public override NPCMatcher CreateMatcher() => new NPCMatcher().MatchType(ModContent.NPCType<global::SpiritMod.NPCs.Boss.Atlas.Atlas>());
            public bool DroppedSummon;
            public override bool SafePreAI(NPC npc)
            {
                if (npc.HasPlayerTarget && !DroppedSummon && npc.boss)
                {
                    Player player = Main.player[npc.target];

                    if (!player.dead)
                    {
                        if (!MyWorld.DownedMoonWizard && FargoSoulsUtil.HostCheck)
                        {
                            Item.NewItem(npc.GetSource_Loot(), player.Hitbox, ModContent.ItemType<StoneSkin>());
                        }
                        DroppedSummon = true;
                    }
                }
                return true;
            }
        }
        public class Dusking : EModeNPCBehaviour
        {
            public override NPCMatcher CreateMatcher() => new NPCMatcher().MatchType(ModContent.NPCType<global::SpiritMod.NPCs.Boss.Dusking.Dusking>());
            public bool DroppedSummon;
            public override bool SafePreAI(NPC npc)
            {
                if (npc.HasPlayerTarget && !DroppedSummon && npc.boss)
                {
                    Player player = Main.player[npc.target];

                    if (!player.dead)
                    {
                        if (!MyWorld.DownedMoonWizard && FargoSoulsUtil.HostCheck)
                        {
                            Item.NewItem(npc.GetSource_Loot(), player.Hitbox, ModContent.ItemType<DuskCrown>());
                        }
                        DroppedSummon = true;
                    }
                }
                return true;
            }
        }
        public class Infernon : EModeNPCBehaviour
        {
            public override NPCMatcher CreateMatcher() => new NPCMatcher().MatchType(ModContent.NPCType<global::SpiritMod.NPCs.Boss.Infernon.Infernon>());
            public bool DroppedSummon;
            public override bool SafePreAI(NPC npc)
            {
                if (npc.HasPlayerTarget && !DroppedSummon && npc.boss)
                {
                    Player player = Main.player[npc.target];

                    if (!player.dead)
                    {
                        if (!MyWorld.DownedMoonWizard && FargoSoulsUtil.HostCheck)
                        {
                            Item.NewItem(npc.GetSource_Loot(), player.Hitbox, ModContent.ItemType<CursedCloth>());
                        }
                        DroppedSummon = true;
                    }
                }
                return true;
            }
        }
        public class MoonJellyWizard : EModeNPCBehaviour
        {
            public override NPCMatcher CreateMatcher() => new NPCMatcher().MatchType(ModContent.NPCType<MoonWizard>());
            public bool DroppedSummon;
            public override bool SafePreAI(NPC npc)
            {
                if (npc.HasPlayerTarget && !DroppedSummon && npc.boss)
                {
                    Player player = Main.player[npc.target];

                    if (!player.dead)
                    {
                        if (!MyWorld.DownedMoonWizard && FargoSoulsUtil.HostCheck)
                        {
                            Item.NewItem(npc.GetSource_Loot(), player.Hitbox, ModContent.ItemType<DreamlightJellyItem>());
                        }
                        DroppedSummon = true;
                    }
                }
                return true;
            }
        }
        public class Scarabeus : EModeNPCBehaviour
        {
            public override NPCMatcher CreateMatcher() => new NPCMatcher().MatchType(ModContent.NPCType<Scarab>());
            public bool DroppedSummon;
            public override bool SafePreAI(NPC npc)
            {
                if (npc.HasPlayerTarget && !DroppedSummon && npc.boss)
                {
                    Player player = Main.player[npc.target];

                    if (!player.dead)
                    {
                        if (!MyWorld.DownedScarabeus && FargoSoulsUtil.HostCheck)
                        {
                            Item.NewItem(npc.GetSource_Loot(), player.Hitbox, ModContent.ItemType<ScarabIdol>());
                        }
                        DroppedSummon = true;
                    }
                }
                return true;
            }
        }
        public class StarplateVoyager : EModeNPCBehaviour
        {
            public override NPCMatcher CreateMatcher() => new NPCMatcher().MatchType(ModContent.NPCType<SteamRaiderHead>());
            public bool DroppedSummon;
            public override bool SafePreAI(NPC npc)
            {
                if (npc.HasPlayerTarget && !DroppedSummon && npc.boss)
                {
                    Player player = Main.player[npc.target];

                    if (!player.dead)
                    {
                        if (!MyWorld.DownedMoonWizard && FargoSoulsUtil.HostCheck)
                        {
                            Item.NewItem(npc.GetSource_Loot(), player.Hitbox, ModContent.ItemType<StarWormSummon>());
                        }
                        DroppedSummon = true;
                    }
                }
                return true;
            }
        }
        public class VinewraithBane : EModeNPCBehaviour
        {
            public override NPCMatcher CreateMatcher() => new NPCMatcher().MatchType(ModContent.NPCType<ReachBoss>());
            public bool DroppedSummon;
            public override bool SafePreAI(NPC npc)
            {
                if (npc.HasPlayerTarget && !DroppedSummon && npc.boss)
                {
                    Player player = Main.player[npc.target];

                    if (!player.dead)
                    {
                        if (!MyWorld.DownedMoonWizard && FargoSoulsUtil.HostCheck)
                        {
                            Item.NewItem(npc.GetSource_Loot(), player.Hitbox, ModContent.ItemType<ReachBossSummon>());
                        }
                        DroppedSummon = true;
                    }
                }
                return true;
            }
        }
    }
}