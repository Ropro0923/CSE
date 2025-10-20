using Fargowiltas.Content.Items.Ammos;
using SpiritMod.Items.Ammo.Arrow;
using SpiritMod.Items.Ammo.Bullet;
using SpiritMod.Items.Ammo.Rocket.Warhead;

namespace ResonantSouls.SpiritMod.QOL.InfiniteAmmo
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class EndlessAccursedQuiver : BaseAmmo
    {
        public override int AmmunitionItem => ModContent.ItemType<SepulchreArrow>();
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class EndlessBeetleQuiver : BaseAmmo
    {
        public override int AmmunitionItem => ModCompatibility.SpiritMod.Mod.Find<ModItem>("BeetleArrow").Type;
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class EndlessRipperPouch : BaseAmmo
    {
        public override int AmmunitionItem => ModContent.ItemType<RipperSlug>();
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class EndlessRubberPouch : BaseAmmo
    {
        public override int AmmunitionItem => ModContent.ItemType<RubberBullet>();
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class EndlessSpectrePouch : BaseAmmo
    {
        public override int AmmunitionItem => ModContent.ItemType<SpectreBullet>();
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class EndlessFaerieStarPouch : BaseAmmo
    {
        public override int AmmunitionItem => ModCompatibility.SpiritMod.Mod.Find<ModItem>("FaerieStar").Type;
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class EndlessWarheadBox : BaseAmmo
    {
        public override int AmmunitionItem => ModContent.ItemType<Warhead>();
    }
}