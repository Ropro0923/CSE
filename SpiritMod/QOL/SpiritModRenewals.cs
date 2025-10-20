using Fargowiltas.Content.Items.Renewals;
using Fargowiltas.Content.Projectiles;
using SpiritMod.Projectiles.Solutions;
using SpiritMod.Tiles.Block;
using SpiritMod.Tiles.Walls.Natural;
using Terraria.Audio;
using Terraria.DataStructures;

namespace ResonantSouls.SpiritMod.QOL
{
    #region Items
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class SpiritRenewal : BaseRenewalItem
    {
        public override string Texture => $"ResonantSouls/Assets/Textures/Content/Projectiles/Renewals/{Name}";
        public SpiritRenewal() : base("Spirit Renewal", "Turns a large radius into the Spirit", ModCompatibility.SpiritMod.Mod.Find<ModItem>("SpiritSolution").Type)
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
        public override string Texture => $"ResonantSouls/Assets/Textures/Content/Projectiles/Renewals/{Name}";
        public SpiritRenewalSupreme() : base("Spirit Renewal Supreme", "Turns the whole world into the Spirit", -1, true, ModContent.ItemType<SpiritRenewal>())
        {
        }
        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            Projectile.NewProjectile(player.GetSource_ItemUse(source.Item), position, velocity, ModContent.ProjectileType<SpiritRenewalSupremeProjectile>(), 0, 0, Main.myPlayer);
            return false;
        }
    }

    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class BriarRenewal : BaseRenewalItem
    {
        public override string Texture => $"ResonantSouls/Assets/Textures/Content/Projectiles/Renewals/{Name}";
        public BriarRenewal() : base("Briar Renewal", "Turns a large radius into the Briar", ModCompatibility.SpiritMod.Mod.Find<ModItem>("OliveSolution").Type)
        {
        }
        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            Projectile.NewProjectile(player.GetSource_ItemUse(source.Item), position, velocity, ModContent.ProjectileType<BriarRenewalProjectile>(), 0, 0, Main.myPlayer);
            return false;
        }
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class BriarRenewalSupreme : BaseRenewalItem
    {
        public override string Texture => $"ResonantSouls/Assets/Textures/Content/Projectiles/Renewals/{Name}";
        public BriarRenewalSupreme() : base("Briar Renewal Supreme", "Turns the whole world into the Briar", -1, true, ModContent.ItemType<BriarRenewal>())
        {
        }
        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            Projectile.NewProjectile(player.GetSource_ItemUse(source.Item), position, velocity, ModContent.ProjectileType<BriarRenewalSupremeProjectile>(), 0, 0, Main.myPlayer);
            return false;
        }
    }

    #endregion Items
    #region Projectiles
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class SpiritRenewalProjectile : RenewalBaseProj
    {
        public override string Texture => "ResonantSouls/Assets/Textures/Content/Projectiles/Renewals/SpiritRenewal";
        public SpiritRenewalProjectile() : base("SpiritRenewal", ModContent.ProjectileType<SpiritSolution>(), 1, false)
        {
        }
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class SpiritRenewalSupremeProjectile : RenewalBaseProj
    {
        public override string Texture => "ResonantSouls/Assets/Textures/Content/Projectiles/Renewals/SpiritRenewalSupreme";
        public SpiritRenewalSupremeProjectile() : base("SpiritRenewalSupreme", ModContent.ProjectileType<SpiritSolution>(), 1, true)
        {
        }
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class BriarRenewalProjectile : RenewalBaseProj
    {
        public override string Texture => "ResonantSouls/Assets/Textures/Content/Projectiles/Renewals/BriarRenewal";
        public BriarRenewalProjectile() : base("BriarRenewal", ModContent.ProjectileType<BriarSolution>(), 1, false)
        {
        }
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class BriarRenewalSupremeProjectile : RenewalBaseProj
    {
        public override string Texture => "ResonantSouls/Assets/Textures/Content/Projectiles/Renewals/BriarRenewalSupreme";
        public BriarRenewalSupremeProjectile() : base("BriarRenewalSupreme", ModContent.ProjectileType<BriarSolution>(), 1, true)
        {
        }
    }
    #endregion Projectiles
}