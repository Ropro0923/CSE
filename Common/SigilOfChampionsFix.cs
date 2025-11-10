using FargowiltasSouls.Content.Items.Summons;
using FargowiltasSouls.Core.Globals;

namespace ResonantSouls.Common
{
    public class SigilOfChampionsFix : GlobalItem
    {
        public override bool CanUseItem(Item item, Player player)
        {
            if (item.ModItem is SigilOfChampions)
            {
                for (int i = 0; i < Main.maxNPCs; i++)
                {
                    if (Main.npc[i].active && i == EModeGlobalNPC.championBoss)
                        return false;
                }
                return true;
            }
            return base.CanUseItem(item, player);
        }
    }
}