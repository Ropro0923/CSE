using Fargowiltas.Content.NPCs;
using SOR.SpiritMod.Core;
using SpiritMod;
using SpiritMod.Items.Consumable;
using SpiritMod.Items.Placeable.Tiles;
using SpiritMod.Items.Sets.FloatingItems.Driftwood;

namespace SOR.SpiritMod.QOL
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class SpiritModSiblingsShop : GlobalNPC
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
                shop.Add(new Item(ModContent.ItemType<DistressJellyItem>()) { shopCustomPrice = Item.buyPrice(platinum: 0, gold: 0, silver: 4, copper: 30) }, SpiritModConditions.DefeatedJellyDeluge);
                shop.Add(new Item(ModContent.ItemType<BlueMoonSpawn>()) { shopCustomPrice = Item.buyPrice(platinum: 0, gold: 17, silver: 20, copper: 0) }, SpiritModConditions.DefeatedMysticMoon);
                shop.Add(new Item(ModContent.ItemType<BlackPearl>()) { shopCustomPrice = Item.buyPrice(platinum: 0, gold: 12, silver: 50, copper: 0) }, SpiritModConditions.DefeatedTide);
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
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]   
    public class SpiritModMutantShop : ModSystem
    {
        public override void PostSetupContent()
        {
            ModCompatibility.Fargowiltas.Mod.Call("AddSummon", 1f, "SOR", "ScarabIdol", () => MyWorld.DownedScarabeus, Item.buyPrice(platinum: 0, gold: 4, silver: 10, copper: 0));
            ModCompatibility.Fargowiltas.Mod.Call("AddSummon", 1f, "SOR", "DreamlightJellyItem", () => MyWorld.DownedMoonWizard, Item.buyPrice(platinum: 0, gold: 7, silver: 90, copper: 0));
            ModCompatibility.Fargowiltas.Mod.Call("AddSummon", 1f, "SOR", "ReachBossSummon", () => MyWorld.DownedVinewrath, Item.buyPrice(platinum: 0, gold: 18, silver: 10, copper: 0));
            ModCompatibility.Fargowiltas.Mod.Call("AddSummon", 1f, "SOR", "JewelCrown", () => MyWorld.DownedAncientAvian, Item.buyPrice(platinum: 0, gold: 20, silver: 0, copper: 0));
            ModCompatibility.Fargowiltas.Mod.Call("AddSummon", 1f, "SOR", "StarWormSummon", () => MyWorld.DownedStarplate, Item.buyPrice(platinum: 0, gold: 25, silver: 30, copper: 0));
            ModCompatibility.Fargowiltas.Mod.Call("AddSummon", 1f, "SOR", "CursedCloth", () => MyWorld.DownedInfernon, Item.buyPrice(platinum: 0, gold: 33, silver: 20, copper: 0));
            ModCompatibility.Fargowiltas.Mod.Call("AddSummon", 1f, "SOR", "DuskCrown", () => MyWorld.DownedDusking, Item.buyPrice(platinum: 0, gold: 68, silver: 50, copper: 0));
            ModCompatibility.Fargowiltas.Mod.Call("AddSummon", 1f, "SOR", "StoneSkin", () => MyWorld.DownedAtlas, Item.buyPrice(platinum: 0, gold: 99, silver: 0, copper: 0));
        }
    }
}