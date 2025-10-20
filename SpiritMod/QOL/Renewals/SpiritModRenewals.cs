using Fargowiltas.Content.Items.Renewals;
using Fargowiltas.Content.Projectiles;
using SpiritMod.Items.Ammo;
using Terraria.DataStructures;

namespace ResonantSouls.SpiritMod.QOL.Renewals
{
    #region Items
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class SpiritRenewal : BaseRenewalItem
    {
        public SpiritRenewal() : base("Spirit Renewal", "Turns a large radius into the spirit biome", ModContent.ItemType<SpiritSolution>())
        {
        }
        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            Projectile.NewProjectile(player.GetSource_ItemUse(source.Item), position, velocity, ModContent.ProjectileType<SpiritRenewalProjectile>(), 0, 0, Main.myPlayer);
            return false;
        }
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class SpiritRenewalSupreme : BaseRenewalItem
    {
        public SpiritRenewalSupreme() : base("Spirit Renewal Supreme", "Corrupts the entire world", -1, true, ModContent.ItemType<SpiritRenewal>())
        {
        }
        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            Projectile.NewProjectile(player.GetSource_ItemUse(source.Item), position, velocity, ModContent.ProjectileType<SpiritRenewalSupremeProjectile>(), 0, 0, Main.myPlayer);
            return false;
        }
    }
    #endregion Items
    #region Projectiles
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class SpiritRenewalProjectile : RenewalBaseProj
    {
        public override string Texture => "ResonantSouls/SpiritMod/QOL/Renewals/SpiritRenewal";
        public SpiritRenewalProjectile() : base("SpiritRenewal", ModContent.ProjectileType<global::SpiritMod.Projectiles.Solutions.SpiritSolution>(), 1, false)
        {
        }
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class SpiritRenewalSupremeProjectile : RenewalBaseProj
    {
        public override string Texture => "ResonantSouls/SpiritMod/QOL/Renewals/SpiritRenewalSupreme";
        public SpiritRenewalSupremeProjectile() : base("SpiritRenewalSupreme", ModContent.ProjectileType<global::SpiritMod.Projectiles.Solutions.SpiritSolution>(), 1, true)
        {
        }
    }
    #endregion Projectiles
}