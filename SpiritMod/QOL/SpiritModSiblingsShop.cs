using Fargowiltas.Content.NPCs;
using ResonantSouls.SpiritMod.Core;
using SpiritMod;
using SpiritMod.Items.Consumable;
using SpiritMod.Items.Placeable.Tiles;
using SpiritMod.Items.Sets.FloatingItems.Driftwood;

namespace ResonantSouls.SpiritMod.QOL
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class SpiritModSiblingsShop : GlobalNPC
    {
        public override bool InstancePerEntity => true;
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.QualityOfLife;
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
                shop.Add(new Item(ModContent.ItemType<AncientTentacle>()) { shopCustomPrice = Item.buyPrice(platinum: 0, gold: 14, silver: 0, copper: 0) }, SpiritModConditions.DefeatedTide);
                shop.Add(new Item(ModContent.ItemType<OccultistsRobe>()) { shopCustomPrice = Item.buyPrice(platinum: 0, gold: 5, silver: 12, copper: 0) }, Condition.BloodMoon);
                shop.Add(new Item(ModContent.ItemType<FrostLantern>()) { shopCustomPrice = Item.buyPrice(platinum: 0, gold: 16, silver: 20, copper: 0) }, Condition.DownedFrostLegion);
            }
            if (shop.NpcType == ModContent.NPCType<Deviantt>())
            {
                shop.Add(new Item(ModContent.ItemType<BrightFeather>()) { shopCustomPrice = Item.buyPrice(platinum: 0, gold: 6, silver: 18, copper: 0) }, SpiritModConditions.DefeatedValkyrie);
                shop.Add(new Item(ModContent.ItemType<CloakedHat>()) { shopCustomPrice = Item.buyPrice(platinum: 0, gold: 7, silver: 56, copper: 0) }, SpiritModConditions.DefeatedDarkfeatherMage);
                shop.Add(new Item(ModContent.ItemType<BrokenHalo>()) { shopCustomPrice = Item.buyPrice(platinum: 0, gold: 17, silver: 12, copper: 0) }, SpiritModConditions.DefeatedVultureMatriarch);
                shop.Add(new Item(ModContent.ItemType<AvianCrown>()) { shopCustomPrice = Item.buyPrice(platinum: 0, gold: 5, silver: 12, copper: 0) }, SpiritModConditions.DefeatedVultureMatriarch);
                shop.Add(new Item(ModContent.ItemType<GladeLeaves>()) { shopCustomPrice = Item.buyPrice(platinum: 0, gold: 2, silver: 8, copper: 0) }, SpiritModConditions.DefeatedGladeWraith);
                shop.Add(new Item(ModContent.ItemType<HauntedPage>()) { shopCustomPrice = Item.buyPrice(platinum: 0, gold: 2, silver: 10, copper: 0) }, SpiritModConditions.DefeatedHauntedTome);
                shop.Add(new Item(ModContent.ItemType<OccultistsRobe>()) { shopCustomPrice = Item.buyPrice(platinum: 0, gold: 3, silver: 8, copper: 0) }, SpiritModConditions.DefeatedOccultist);
                shop.Add(new Item(ModContent.ItemType<SporePouch>()) { shopCustomPrice = Item.buyPrice(platinum: 0, gold: 3, silver: 20, copper: 0) }, SpiritModConditions.DefeatedSnaptrapper);
                shop.Add(new Item(ModContent.ItemType<MarbleEye>()) { shopCustomPrice = Item.buyPrice(platinum: 0, gold: 12, silver: 21, copper: 0) }, SpiritModConditions.DefeatedBeholder);
                shop.Add(new Item(ModContent.ItemType<MechanicalOrb>()) { shopCustomPrice = Item.buyPrice(platinum: 0, gold: 8, silver: 18, copper: 0) }, SpiritModConditions.DefeatedMechromancer);
            }
        }
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]   
    public class SpiritModMutantShop : ModSystem
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.QualityOfLife;
        public override void PostSetupContent()
        {
            ModCompatibility.Fargowiltas.Mod.Call("AddSummon", 1f, "SpiritMod", "ScarabIdol", () => MyWorld.DownedScarabeus, Item.buyPrice(platinum: 0, gold: 4, silver: 10, copper: 0));
            ModCompatibility.Fargowiltas.Mod.Call("AddSummon", 1f, "SpiritMod", "DreamlightJellyItem", () => MyWorld.DownedMoonWizard, Item.buyPrice(platinum: 0, gold: 7, silver: 90, copper: 0));
            ModCompatibility.Fargowiltas.Mod.Call("AddSummon", 1f, "SpiritMod", "ReachBossSummon", () => MyWorld.DownedVinewrath, Item.buyPrice(platinum: 0, gold: 18, silver: 10, copper: 0));
            ModCompatibility.Fargowiltas.Mod.Call("AddSummon", 1f, "SpiritMod", "JewelCrown", () => MyWorld.DownedAncientAvian, Item.buyPrice(platinum: 0, gold: 20, silver: 0, copper: 0));
            ModCompatibility.Fargowiltas.Mod.Call("AddSummon", 1f, "SpiritMod", "StarWormSummon", () => MyWorld.DownedStarplate, Item.buyPrice(platinum: 0, gold: 25, silver: 30, copper: 0));
            ModCompatibility.Fargowiltas.Mod.Call("AddSummon", 1f, "SpiritMod", "CursedCloth", () => MyWorld.DownedInfernon, Item.buyPrice(platinum: 0, gold: 33, silver: 20, copper: 0));
            ModCompatibility.Fargowiltas.Mod.Call("AddSummon", 1f, "SpiritMod", "DuskCrown", () => MyWorld.DownedDusking, Item.buyPrice(platinum: 0, gold: 68, silver: 50, copper: 0));
            ModCompatibility.Fargowiltas.Mod.Call("AddSummon", 1f, "SpiritMod", "StoneSkin", () => MyWorld.DownedAtlas, Item.buyPrice(platinum: 0, gold: 99, silver: 0, copper: 0));
        }
    }
}