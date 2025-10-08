using FargowiltasSouls;
using FargowiltasSouls.Core.Globals;
using FargowiltasSouls.Core.NPCMatching;
using SpiritMod;
using SpiritMod.Items.Consumable;
using SpiritMod.NPCs.Boss.Scarabeus;

namespace CSE.SpiritMod.Content.Bosses
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
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
}
