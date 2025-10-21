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
        public override void OnKill(int timeLeft)
        {
            SoundEngine.PlaySound(SoundID.Shatter, Projectile.Center);

            int radius = 150;
            float[] speedX = [0, 0, 5, 5, 5, -5, -5, -5];
            float[] speedY = [5, -5, 0, 5, -5, 0, 5, -5];

            if (Main.netMode == NetmodeID.SinglePlayer)
            {
                for (int i = 0; i < 8; i++)
                {
                    Projectile.NewProjectile(Projectile.GetSource_FromThis(), Projectile.Center.X, Projectile.Center.Y, speedX[i], speedY[i], ModContent.ProjectileType<SpiritSolution>(), 0, 0, Main.myPlayer);
                }
            }
            for (int x = -radius; x <= radius; x++)
            {
                for (int y = -radius; y <= radius; y++)
                {
                    int xPosition = (int)(x + Projectile.Center.X / 16.0f);
                    int yPosition = (int)(y + Projectile.Center.Y / 16.0f);

                    if (Math.Sqrt(x * x + y * y) <= radius + 0.5)
                    {
                        SpiritModRenewals.ConvertToSpirit(xPosition, yPosition);
                    }
                }
            }
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
        public override void OnKill(int timeLeft)
        {
            SoundEngine.PlaySound(SoundID.Shatter, Projectile.Center);

            float[] speedX = [0, 0, 5, 5, 5, -5, -5, -5];
            float[] speedY = [5, -5, 0, 5, -5, 0, 5, -5];

            if (Main.netMode == NetmodeID.SinglePlayer)
            {
                for (int i = 0; i < 8; i++)
                {
                    Projectile.NewProjectile(Projectile.GetSource_FromThis(), Projectile.Center.X, Projectile.Center.Y, speedX[i], speedY[i], ModContent.ProjectileType<SpiritSolution>(), 0, 0, Main.myPlayer);
                }
            }

            for (int x = -Main.maxTilesX; x < Main.maxTilesX; x++)
            {
                for (int y = -Main.maxTilesY; y < Main.maxTilesY; y++)
                {
                    int xPosition = (int)(x + Projectile.Center.X / 16.0f);
                    int yPosition = (int)(y + Projectile.Center.Y / 16.0f);

                    SpiritModRenewals.ConvertToSpirit(xPosition, yPosition);
                }
            }
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
        public override void OnKill(int timeLeft)
        {
            SoundEngine.PlaySound(SoundID.Shatter, Projectile.Center);

            int radius = 150;
            float[] speedX = [0, 0, 5, 5, 5, -5, -5, -5];
            float[] speedY = [5, -5, 0, 5, -5, 0, 5, -5];

            if (Main.netMode == NetmodeID.SinglePlayer)
            {
                for (int i = 0; i < 8; i++)
                {
                    Projectile.NewProjectile(Projectile.GetSource_FromThis(), Projectile.Center.X, Projectile.Center.Y, speedX[i], speedY[i], ModContent.ProjectileType<BriarSolution>(), 0, 0, Main.myPlayer);
                }
            }
            for (int x = -radius; x <= radius; x++)
            {
                for (int y = -radius; y <= radius; y++)
                {
                    int xPosition = (int)(x + Projectile.Center.X / 16.0f);
                    int yPosition = (int)(y + Projectile.Center.Y / 16.0f);

                    if (Math.Sqrt(x * x + y * y) <= radius + 0.5)
                    {
                        SpiritModRenewals.ConvertToBriar(xPosition, yPosition);
                    }
                }
            }
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
        public override void OnKill(int timeLeft)
        {
            SoundEngine.PlaySound(SoundID.Shatter, Projectile.Center);

            float[] speedX = [0, 0, 5, 5, 5, -5, -5, -5];
            float[] speedY = [5, -5, 0, 5, -5, 0, 5, -5];

            if (Main.netMode == NetmodeID.SinglePlayer)
            {
                for (int i = 0; i < 8; i++)
                {
                    Projectile.NewProjectile(Projectile.GetSource_FromThis(), Projectile.Center.X, Projectile.Center.Y, speedX[i], speedY[i], ModContent.ProjectileType<SpiritSolution>(), 0, 0, Main.myPlayer);
                }
            }

            for (int x = -Main.maxTilesX; x < Main.maxTilesX; x++)
            {
                for (int y = -Main.maxTilesY; y < Main.maxTilesY; y++)
                {
                    int xPosition = (int)(x + Projectile.Center.X / 16.0f);
                    int yPosition = (int)(y + Projectile.Center.Y / 16.0f);

                    SpiritModRenewals.ConvertToBriar(xPosition, yPosition);
                }
            }
        }
    }
    #endregion Projectiles
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class SpiritModRenewals : ModSystem
    {
        public override void PostSetupContent()
        {
            WallID.Sets.Conversion.Grass[ModContent.WallType<SpiritWallNatural>()] = true;
            TileID.Sets.Conversion.Stone[ModContent.TileType<SpiritStone>()] = true;
            TileID.Sets.Conversion.Dirt[ModContent.TileType<SpiritDirt>()] = true;
            TileID.Sets.Conversion.Grass[ModContent.TileType<SpiritGrass>()] = true;
            TileID.Sets.Conversion.Sand[ModContent.TileType<Spiritsand>()] = true;
            TileID.Sets.Conversion.Sand[ModContent.TileType<Spiritsand>()] = true;
            TileID.Sets.Conversion.Ice[ModContent.TileType<SpiritIce>()] = true;
            WallID.Sets.Conversion.Grass[ModContent.WallType<ReachWallNatural>()] = true;
            TileID.Sets.Conversion.Grass[ModContent.TileType<BriarGrass>()] = true;
        }
        public static void ConvertToSpirit(int x, int y)
        {
            if (!WorldGen.InWorld(x, y, 1))
                return;

            Tile tile = Framing.GetTileSafely(x, y);

            if (!tile.HasTile)
                return;

            if (WallID.Sets.Conversion.Grass[tile.WallType] && tile.WallType != (ushort)ModContent.WallType<SpiritWallNatural>())
            {
                tile.WallType = (ushort)ModContent.WallType<SpiritWallNatural>();
                WorldGen.SquareWallFrame(x, y);
                NetMessage.SendTileSquare(-1, x, y, 1);
            }
            if ((TileID.Sets.Conversion.Stone[tile.TileType] || TileID.Sets.Conversion.Moss[tile.TileType]) && tile.TileType != (ushort)ModContent.TileType<SpiritStone>())
            {
                tile.TileType = (ushort)ModContent.TileType<SpiritStone>();
                WorldGen.SquareTileFrame(x, y);
                NetMessage.SendTileSquare(-1, x, y, 1);
            }
            if (TileID.Sets.Conversion.Dirt[tile.TileType] && tile.TileType != ModContent.TileType<SpiritDirt>())
            {
                tile.TileType = (ushort)ModContent.TileType<SpiritDirt>();
                WorldGen.SquareTileFrame(x, y);
                NetMessage.SendTileSquare(-1, x, y, 1);
            }
            else if (TileID.Sets.Conversion.Grass[tile.TileType] && tile.TileType != (ushort)ModContent.TileType<SpiritGrass>())
            {
                tile.TileType = (ushort)ModContent.TileType<SpiritGrass>();
                WorldGen.SquareTileFrame(x, y);
                NetMessage.SendTileSquare(-1, x, y, 1);
            }
            else if (TileID.Sets.Conversion.Sand[tile.TileType] && tile.TileType != (ushort)ModContent.TileType<Spiritsand>())
            {
                tile.TileType = (ushort)ModContent.TileType<Spiritsand>();
                WorldGen.SquareTileFrame(x, y);
                NetMessage.SendTileSquare(-1, x, y, 1);
            }
            else if (TileID.Sets.Conversion.Ice[tile.TileType])
            {
                tile.TileType = (ushort)ModContent.TileType<SpiritIce>();
                WorldGen.SquareTileFrame(x, y);
                NetMessage.SendTileSquare(-1, x, y, 1);
            }
        }
        public static void ConvertToBriar(int x, int y)
        {
            if (!WorldGen.InWorld(x, y, 1))
                return;

            Tile tile = Framing.GetTileSafely(x, y);

            if (!tile.HasTile)
                return;

            if (WallID.Sets.Conversion.Grass[tile.WallType] && tile.WallType != (ushort)ModContent.WallType<ReachWallNatural>())
            {
                tile.WallType = (ushort)ModContent.WallType<ReachWallNatural>();
                WorldGen.SquareWallFrame(x, y);
            }

            if (TileID.Sets.Conversion.Grass[tile.TileType] && tile.TileType != (ushort)ModContent.TileType<BriarGrass>())
            {
                tile.TileType = (ushort)ModContent.TileType<BriarGrass>();

            }
            else if (tile.TileType == ModContent.TileType<SpiritDirt>())
            {
                tile.TileType = TileID.Dirt;
            }
            else return;
            WorldGen.SquareTileFrame(x, y);
            NetMessage.SendTileSquare(-1, x, y, 1);
        }
    }
}