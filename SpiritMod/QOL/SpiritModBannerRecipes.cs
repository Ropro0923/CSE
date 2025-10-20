using Fargowiltas.Common.Configs;
using SpiritMod.Items.Accessory;
using SpiritMod.Items.Accessory.ShieldCore;
using SpiritMod.Items.Armor.AstronautVanity;
using SpiritMod.Items.Armor.DiverSet;
using SpiritMod.Items.Armor.PlagueDoctor;
using SpiritMod.Items.Banners;
using SpiritMod.Items.Consumable.Potion;
using SpiritMod.Items.Equipment;
using SpiritMod.Items.Placeable.IceSculpture;
using SpiritMod.Items.Sets.BriarDrops;
using SpiritMod.Items.Sets.EvilBiomeDrops.Heartillery;
using SpiritMod.Items.Sets.FlailsMisc.ClatterMace;
using SpiritMod.Items.Sets.GunsMisc.MeteoriteSpewer;
using SpiritMod.Items.Sets.MagicMisc.Arclash;
using SpiritMod.Items.Sets.MagicMisc.AstralClock;
using SpiritMod.Items.Sets.SpiritBiomeDrops;
using SpiritMod.Items.Sets.TideDrops;
using SpiritMod.Items.Weapon.Summon;
using SpiritMod.Items.Weapon.Summon.ElectricGun;
using SpiritMod.Items.Weapon.Yoyo;

namespace ResonantSouls.SpiritMod.QOL
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class SpiritModBannerRecipes : ModSystem
    {
        public override bool IsLoadingEnabled(Mod mod) => FargoServerConfig.Instance.BannerRecipes;
        public override void AddRecipes()
        {
            Recipe.Create(ModContent.ItemType<Obolos>())
                .AddIngredient<AncientSpectreBanner>(1)
                .AddTile(TileID.Solidifier)
                .AddCondition(Condition.Hardmode)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<Obolos>())
                .AddIngredient<SpiritTomeBanner>(1)
                .AddTile(TileID.Solidifier)
                .AddCondition(Condition.Hardmode)
                .DisableDecraft()
                .Register();

            Recipe.Create(ItemID.ArmorPolish)
                .AddIngredient<ArachmatonBanner>(1)
                .AddTile(TileID.Solidifier)
                .AddCondition(Condition.Hardmode)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<HeartilleryBeacon>())
                .AddIngredient<ArterialGrasperBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<Meteorite_Spewer>())
                .AddIngredient<AstralAdventurerBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<AstronautHelm>())
                .AddIngredient<AstralAmalgamBanner>(2)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<AstronautBody>())
                .AddIngredient<AstralAmalgamBanner>(2)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<AstronautLegs>())
                .AddIngredient<AstralAmalgamBanner>(2)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<GravityModulator>())
                .AddIngredient<AstralAmalgamBanner>(2)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<ShieldCore>())
                .AddIngredient<AstralAmalgamBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ItemID.FrostStaff)
                .AddIngredient<BlizzardNimbusBanner>(1)
                .AddTile(TileID.Solidifier)
                .AddCondition(Condition.Hardmode)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<DiverHead>())
                .AddIngredient<BloatfishBanner>(2)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<DiverBody>())
                .AddIngredient<BloatfishBanner>(2)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<DiverLegs>())
                .AddIngredient<BloatfishBanner>(2)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ItemID.BalloonPufferfish)
                .AddIngredient<BloatfishBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<StopWatch>())
                .AddIngredient<BloomshroomBanner>(1)
                .AddTile(TileID.Solidifier)
                .AddCondition(Condition.Hardmode)
                .Register();

            Recipe.Create(ModContent.ItemType<GloomgusStaff>())
                .AddIngredient<BloomshroomBanner>(1)
                .AddTile(TileID.Solidifier)
                .AddCondition(Condition.Hardmode)
                .Register();

            Recipe.Create(ModContent.ItemType<AnodyneHat>())
                .AddIngredient<BlossomHoundBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ItemID.Nazar)
                .AddIngredient<BlueDungeonCubeBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ItemID.TallyCounter)
                .AddIngredient<BlueDungeonCubeBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ItemID.DepthMeter)
                .AddIngredient<CavernCrawlerBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ItemID.Compass)
                .AddIngredient<CavernCrawlerBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ItemID.Rally)
                .AddIngredient<CavernCrawlerBanner>(2)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<CrocodrilloMountItem>())
                .AddIngredient<CrocosaurBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<PlagueDoctorCowl>())
                .AddIngredient<DarkAlchemistBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<PlagueDoctorRobe>())
                .AddIngredient<DarkAlchemistBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<PlagueDoctorCowl>())
                .AddIngredient<DarkAlchemistBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ItemID.Nazar)
                .AddIngredient<DarkAlchemistBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ItemID.TallyCounter)
                .AddIngredient<DarkAlchemistBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ItemID.GoldenKey)
                .AddIngredient<DarkAlchemistBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ItemID.BoneWand)
                .AddIngredient<DarkAlchemistBanner>(2)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<PlagueDoctorCowl>())
                .AddIngredient<CrocosaurBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ItemID.BlackLens)
                .AddIngredient<DeadeyeMarksmanBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<PlagueDoctorCowl>())
                .AddIngredient<CrocosaurBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<PlagueDoctorCowl>())
                .AddIngredient<CrocosaurBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<AnodyneHat>())
                .AddIngredient<ReachmanBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ItemID.Nazar)
                .AddIngredient<GhastBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ItemID.TallyCounter)
                .AddIngredient<GhastBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ItemID.GoldenKey)
                .AddIngredient<GhastBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ItemID.BoneWand)
                .AddIngredient<GhastBanner>(2)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ItemID.BoneWand)
                .AddIngredient<GhastBanner>(2)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<AnodyneHat>())
                .AddIngredient<GladeWraithBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<AnodyneHat>())
                .AddIngredient<ReachmanBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ItemID.GladiatorHelmet)
                .AddIngredient<GladiatorSpiritBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ItemID.GladiatorBreastplate)
                .AddIngredient<GladiatorSpiritBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ItemID.GladiatorLeggings)
                .AddIngredient<GladiatorSpiritBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ItemID.GladiatorHelmet)
                .AddIngredient<GladiatorSpiritBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<AstronautHelm>())
                .AddIngredient<GloopBanner>(2)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<AstronautBody>())
                .AddIngredient<GloopBanner>(2)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<AstronautLegs>())
                .AddIngredient<GloopBanner>(2)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<GravityModulator>())
                .AddIngredient<GloopBanner>(2)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<GravityModulator>())
                .AddIngredient<GloopBanner>(2)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ItemID.NightVisionHelmet)
                .AddIngredient<GraniteSlimeBanner>(2)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ItemID.Nazar)
                .AddIngredient<GreenDungeonCubeBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ItemID.TallyCounter)
                .AddIngredient<GreenDungeonCubeBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ItemID.TallyCounter)
                .AddIngredient<PinkDungeonCubeBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ItemID.Nazar)
                .AddIngredient<PinkDungeonCubeBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ItemID.Nazar)
                .AddIngredient<PinkDungeonCubeBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<Meteorite_Spewer>())
                .AddIngredient<MoltenCoreBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<ArcLash>())
                .AddIngredient<MoonlightPreserverBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<ElectricGun>())
                .AddIngredient<MoonlightPreserverBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<Moonburst>())
                .AddIngredient<MoonlightRupturerBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<GravityModulator>())
                .AddIngredient<OrbititeBanner>(2)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<AstronautHelm>())
                .AddIngredient<OrbititeBanner>(2)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<AstronautBody>())
                .AddIngredient<OrbititeBanner>(2)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<AstronautLegs>())
                .AddIngredient<OrbititeBanner>(2)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<GravityModulator>())
                .AddIngredient<ShockhopperBanner>(2)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<AstronautHelm>())
                .AddIngredient<ShockhopperBanner>(2)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<AstronautBody>())
                .AddIngredient<ShockhopperBanner>(2)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<AstronautLegs>())
                .AddIngredient<ShockhopperBanner>(2)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<ClatterMace>())
                .AddIngredient<SporeWheezerBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ItemID.Compass)
                .AddIngredient<SporeWheezerBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ItemID.DepthMeter)
                .AddIngredient<SporeWheezerBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ItemID.Rally)
                .AddIngredient<SporeWheezerBanner>(2)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<AnodyneHat>())
                .AddIngredient<ThornStalkerBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ItemID.GiantHarpyFeather)
                .AddIngredient<ValkyrieBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<ClatterMace>())
                .AddIngredient<WheezerBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ItemID.Compass)
                .AddIngredient<WheezerBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ItemID.DepthMeter)
                .AddIngredient<WheezerBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ItemID.Bezoar)
                .AddIngredient<WheezerBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<WinterbornSculpture>())
                .AddIngredient<WinterbornBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<WinterbornSculpture>())
                .AddIngredient<WinterbornHeraldBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<AnodyneHat>())
                .AddIngredient<WildwoodWatcherBanner>(1)
                .AddTile(TileID.Solidifier)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<Obolos>())
                .AddIngredient<SpiritMummyBanner>(1)
                .AddTile(TileID.Solidifier)
                .AddCondition(Condition.Hardmode)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<Obolos>())
                .AddIngredient<SpiritMummyBanner>(1)
                .AddTile(TileID.Solidifier)
                .AddCondition(Condition.Hardmode)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<GoldenApple>())
                .AddIngredient<HydraGreenBanner>(1)
                .AddIngredient<HydraRedBanner>(1)
                .AddIngredient<HydraPurpleBanner>(1)
                .AddTile(TileID.Solidifier)
                .AddCondition(Condition.Hardmode)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<StopWatch>())
                .AddIngredient<GlitterflyBanner>(1)
                .AddTile(TileID.Solidifier)
                .AddCondition(Condition.Hardmode)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<StopWatch>())
                .AddIngredient<GlowToadBanner>(1)
                .AddTile(TileID.Solidifier)
                .AddCondition(Condition.Hardmode)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<StopWatch>())
                .AddIngredient<LumantisBanner>(1)
                .AddTile(TileID.Solidifier)
                .AddCondition(Condition.Hardmode)
                .DisableDecraft()
                .Register();

            Recipe.Create(ItemID.CoinGun)
                .AddIngredient<PirateLobberBanner>(1)
                .AddTile(TileID.Solidifier)
                .AddCondition(Condition.DownedPirates)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<BottomlessAle>())
                .AddIngredient<PirateLobberBanner>(1)
                .AddTile(TileID.Solidifier)
                .AddCondition(Condition.DownedPirates)
                .DisableDecraft()
                .Register();

            Recipe.Create(ItemID.LuckyCoin)
                .AddIngredient<PirateLobberBanner>(1)
                .AddTile(TileID.Solidifier)
                .AddCondition(Condition.DownedPirates)
                .DisableDecraft()
                .Register();

            Recipe.Create(ItemID.DiscountCard)
                .AddIngredient<PirateLobberBanner>(1)
                .AddTile(TileID.Solidifier)
                .AddCondition(Condition.DownedPirates)
                .DisableDecraft()
                .Register();

            Recipe.Create(ItemID.PirateStaff)
                .AddIngredient<PirateLobberBanner>(1)
                .AddTile(TileID.Solidifier)
                .AddCondition(Condition.DownedPirates)
                .DisableDecraft()
                .Register();

            Recipe.Create(ItemID.Cutlass)
                .AddIngredient<PirateLobberBanner>(1)
                .AddTile(TileID.Solidifier)
                .AddCondition(Condition.DownedPirates)
                .DisableDecraft()
                .Register();

            Recipe.Create(ItemID.GoldRing)
                .AddIngredient<PirateLobberBanner>(1)
                .AddTile(TileID.Solidifier)
                .AddCondition(Condition.DownedPirates)
                .DisableDecraft()
                .Register();

            Recipe.Create(ItemID.GoldenShower)
                .AddIngredient<PirateLobberBanner>(1)
                .AddTile(TileID.Solidifier)
                .AddCondition(Condition.DownedPirates)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<Obolos>())
                .AddIngredient<SpiritGhoulBanner>(1)
                .AddTile(TileID.Solidifier)
                .AddCondition(Condition.Hardmode)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<Gravehunter>())
                .AddIngredient<SpiritGhoulBanner>(1)
                .AddTile(TileID.Solidifier)
                .AddCondition(Condition.Hardmode)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<SpiritFlameStaff>())
                .AddIngredient<SpiritSkullBanner>(1)
                .AddTile(TileID.Solidifier)
                .AddCondition(Condition.Hardmode)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<GoldenApple>())
                .AddIngredient<StymphalianBatBanner>(1)
                .AddTile(TileID.Solidifier)
                .AddCondition(Condition.Hardmode)
                .DisableDecraft()
                .Register();

            Recipe.Create(ItemID.AdhesiveBandage)
                .AddIngredient<StymphalianBatBanner>(1)
                .AddTile(TileID.Solidifier)
                .AddCondition(Condition.Hardmode)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<GoldenApple>())
                .AddIngredient<TrochmatonBanner>(1)
                .AddTile(TileID.Solidifier)
                .AddCondition(Condition.Hardmode)
                .DisableDecraft()
                .Register();

            Recipe.Create(ItemID.ArmorPolish)
                .AddIngredient<TrochmatonBanner>(1)
                .AddTile(TileID.Solidifier)
                .AddCondition(Condition.Hardmode)
                .DisableDecraft()
                .Register();

            Recipe.Create(ModContent.ItemType<StoneOfSpiritsPast>())
                .AddIngredient<WanderingSoulBanner>(1)
                .AddTile(TileID.Solidifier)
                .AddCondition(Condition.Hardmode)
                .DisableDecraft()
                .Register();
        }
    }
}