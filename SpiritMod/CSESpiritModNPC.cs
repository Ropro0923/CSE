using Fargowiltas.NPCs;
using SpiritMod.Items.Consumable;
using SpiritMod.Items.Placeable.Tiles;
using SpiritMod.Items.Sets.FloatingItems.Driftwood;
using SpiritMod.NPCs.Vulture_Matriarch;
using Terraria.DataStructures;

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
            if (shop.NpcType == ModContent.NPCType<Mutant>())
            {
                shop.Add(new Item(ModContent.ItemType<GladeWreath>()) { shopCustomPrice = Item.buyPrice(platinum: 0, gold: 4, silver: 10, copper: 0) }, CSESpiritConditions.DefeatedScarabeus);
                shop.Add(new Item(ModContent.ItemType<ScarabIdol>()) { shopCustomPrice = Item.buyPrice(platinum: 0, gold: 4, silver: 10, copper: 0) }, CSESpiritConditions.DefeatedScarabeus);
                shop.Add(new Item(ModContent.ItemType<DreamlightJellyItem>()) { shopCustomPrice = Item.buyPrice(platinum: 0, gold: 7, silver: 90, copper: 0) }, CSESpiritConditions.DefeatedMoonJellyWizard);
                shop.Add(new Item(ModContent.ItemType<ReachBossSummon>()) { shopCustomPrice = Item.buyPrice(platinum: 0, gold: 18, silver: 10, copper: 0) }, CSESpiritConditions.DefeatedVinewraithBane);
                shop.Add(new Item(ModContent.ItemType<JewelCrown>()) { shopCustomPrice = Item.buyPrice(platinum: 0, gold: 20, silver: 0, copper: 0) }, CSESpiritConditions.DefeatedAncientAvian);
                shop.Add(new Item(ModContent.ItemType<StarWormSummon>()) { shopCustomPrice = Item.buyPrice(platinum: 0, gold: 25, silver: 30, copper: 0) }, CSESpiritConditions.DefeatedStarplateVoyager);
                shop.Add(new Item(ModContent.ItemType<CursedCloth>()) { shopCustomPrice = Item.buyPrice(platinum: 0, gold: 33, silver: 20, copper: 0) }, CSESpiritConditions.DefeatedInfernon);
                shop.Add(new Item(ModContent.ItemType<DuskCrown>()) { shopCustomPrice = Item.buyPrice(platinum: 0, gold: 68, silver: 50, copper: 0) }, CSESpiritConditions.DefeatedAncientAvian);
                shop.Add(new Item(ModContent.ItemType<StoneSkin>()) { shopCustomPrice = Item.buyPrice(platinum: 0, gold: 99, silver: 0, copper: 0) }, CSESpiritConditions.DefeatedAtlas);
            }
        }
        public override void OnKill(NPC npc)
        {
            if (npc.type == ModContent.NPCType<Vulture_Matriarch>())
            {
                CSESpiritConditions.defeatedVultureMatriarch = true;
            }
        }
        public override void OnSpawn(NPC npc, IEntitySource source)
        {
            
        }
    }
}