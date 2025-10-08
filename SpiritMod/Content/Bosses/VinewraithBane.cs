using FargowiltasSouls;
using FargowiltasSouls.Core.Globals;
using FargowiltasSouls.Core.NPCMatching;
using SpiritMod;
using SpiritMod.Items.Consumable;
using SpiritMod.NPCs.Boss.ReachBoss;

namespace CSE.SpiritMod.Content.Bosses
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
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
