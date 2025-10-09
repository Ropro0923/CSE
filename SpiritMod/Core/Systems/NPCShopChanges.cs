namespace CSE.SpiritMod.Core.Systems
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]   
    public class NPCShopChanges : ModSystem
    {
        public override void PostSetupContent()
        {
            ModCompatibility.Fargowiltas.Mod.Call("AddSummon", 1f, "CSE", "GladeWreath", () => CSESpiritConditions.DefeatedScarabeus, Item.buyPrice(platinum: 0, gold: 4, silver: 10, copper: 0));
            ModCompatibility.Fargowiltas.Mod.Call("AddSummon", 1f, "CSE", "ScarabIdol", () => CSESpiritConditions.DefeatedScarabeus, Item.buyPrice(platinum: 0, gold: 4, silver: 10, copper: 0));
            ModCompatibility.Fargowiltas.Mod.Call("AddSummon", 1f, "CSE", "DreamlightJellyItem", () => CSESpiritConditions.DefeatedMoonJellyWizard, Item.buyPrice(platinum: 0, gold: 7, silver: 90, copper: 0));
            ModCompatibility.Fargowiltas.Mod.Call("AddSummon", 1f, "CSE", "ReachBossSummon", () => CSESpiritConditions.DefeatedVinewraithBane, Item.buyPrice(platinum: 0, gold: 18, silver: 10, copper: 0));
            ModCompatibility.Fargowiltas.Mod.Call("AddSummon", 1f, "CSE", "JewelCrown", () => CSESpiritConditions.DefeatedAncientAvian, Item.buyPrice(platinum: 0, gold: 20, silver: 0, copper: 0));
            ModCompatibility.Fargowiltas.Mod.Call("AddSummon", 1f, "CSE", "StarWormSummon", () => CSESpiritConditions.DefeatedStarplateVoyager, Item.buyPrice(platinum: 0, gold: 25, silver: 30, copper: 0));
            ModCompatibility.Fargowiltas.Mod.Call("AddSummon", 1f, "CSE", "CursedCloth", () => CSESpiritConditions.DefeatedInfernon, Item.buyPrice(platinum: 0, gold: 33, silver: 20, copper: 0));
            ModCompatibility.Fargowiltas.Mod.Call("AddSummon", 1f, "CSE", "DuskCrown", () => CSESpiritConditions.DefeatedAncientAvian, Item.buyPrice(platinum: 0, gold: 68, silver: 50, copper: 0));
            ModCompatibility.Fargowiltas.Mod.Call("AddSummon", 1f, "CSE", "StoneSkin", () => CSESpiritConditions.DefeatedAtlas, Item.buyPrice(platinum: 0, gold: 99, silver: 0, copper: 0));
        }
    }
}