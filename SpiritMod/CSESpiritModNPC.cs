using CSE.SpiritMod.Core.Systems;
using Fargowiltas.Content.NPCs;
using SpiritMod.Items.Consumable;
using SpiritMod.Items.Placeable.Tiles;
using SpiritMod.Items.Sets.FloatingItems.Driftwood;
using SpiritMod.NPCs.Town;
using SpiritMod.NPCs.Vulture_Matriarch;

namespace CSE.SpiritMod
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class CSESpiritModNPC : GlobalNPC
    {
        public override bool InstancePerEntity => true;
        public override void ModifyShop(NPCShop shop)
        {
            if (shop.NpcType == ModContent.NPCType<LumberJack>())
            {
                shop.Add(new Item(ModContent.ItemType<DriftwoodTileItem>()) { shopCustomPrice = Item.buyPrice(platinum: 0, gold: 0, silver: 0, copper: 5) });
                shop.Add(new Item(ModContent.ItemType<SpiritWoodItem>()) { shopCustomPrice = Item.buyPrice(platinum: 0, gold: 0, silver: 0, copper: 13) });
            }
            if (shop.NpcType == ModContent.NPCType<Abominationn>())
            {
                shop.Add(new Item(ModContent.ItemType<DistressJellyItem>()) { shopCustomPrice = Item.buyPrice(platinum: 0, gold: 0, silver: 4, copper: 30) }, CSESpiritConditions.DefeatedJellyDeluge);
                shop.Add(new Item(ModContent.ItemType<BlueMoonSpawn>()) { shopCustomPrice = Item.buyPrice(platinum: 0, gold: 17, silver: 20, copper: 0) }, CSESpiritConditions.DefeatedMysticMoon);
                shop.Add(new Item(ModContent.ItemType<BlackPearl>()) { shopCustomPrice = Item.buyPrice(platinum: 0, gold: 12, silver: 50, copper: 0) }, CSESpiritConditions.DefeatedTide);
                // Summon for R'lyehian (Tide)
                // Summon for Occultist (Blood Moon)
                // Summon for Snow Monger (Frost Legion)
            }
            if (shop.NpcType == ModContent.NPCType<Deviantt>())
            {
                // Summon for Vulture Matriarch
                // Summon for Glade Wraith
                // Summon for Haunted Tome
                // Summon for Occultist
                // Summon for Beholder
                // Summon for Snaptrapper
                // Summon for Mechromancer

            }
        }
        public override void OnKill(NPC npc)
        {
            if (npc.type == ModContent.NPCType<Vulture_Matriarch>())
            {
                CSESpiritConditions.defeatedVultureMatriarch = true;
            }
        }
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class SpiritModCaughtNPCs
    {
        public static void RegisterSpiritModCaughtNPCs()
        {
            ModCompatibility.Fargowiltas.Mod.Call("AddCaughtNPC", "Adventurer", ModContent.NPCType<Adventurer>(), CSE.Instance.Name);
            ModCompatibility.Fargowiltas.Mod.Call("AddCaughtNPC", "Gambler", ModContent.NPCType<Gambler>(), CSE.Instance.Name);
            ModCompatibility.Fargowiltas.Mod.Call("AddCaughtNPC", "Rogue", ModContent.NPCType<Rogue>(), CSE.Instance.Name);
            ModCompatibility.Fargowiltas.Mod.Call("AddCaughtNPC", "RuneWizard", ModContent.NPCType<RuneWizard>(), CSE.Instance.Name);
        }
    }
}