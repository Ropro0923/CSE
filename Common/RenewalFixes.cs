using Fargowiltas.Content.Projectiles;

namespace ResonantSouls.Common
{
    public class RenewalFixes : GlobalProjectile
    {
        // Janky? Yes. Do I care? Yes. Is there a better way? Yes.  Do I know how to do this? No.
        // Again, thank you to the Fargos Team for their conversion code.
        public override bool AppliesToEntity(Projectile entity, bool lateInstantiation)
        {
            return entity.ModProjectile is RenewalBaseProj;
        }
        public override bool PreKill(Projectile projectile, int timeLeft)
        {
            if (projectile.type.ToString().Contains("Supreme"))
            {
                for (int x = -Main.maxTilesX; x < Main.maxTilesX; x++)
                {
                    for (int y = -Main.maxTilesY; y < Main.maxTilesY; y++)
                    {
                        int xPosition = (int)(x + projectile.Center.X / 16.0f);
                        int yPosition = (int)(y + projectile.Center.Y / 16.0f);

                        ConvertToPurity(xPosition, yPosition);
                    }
                }
            }
            else
            {
                int radius = 150;

                for (int x = -radius; x <= radius; x++)
                {
                    for (int y = -radius; y <= radius; y++)
                    {
                        int xPosition = (int)(x + projectile.Center.X / 16.0f);
                        int yPosition = (int)(y + projectile.Center.Y / 16.0f);

                        if (Math.Sqrt(x * x + y * y) <= radius + 0.5)
                        {
                            ConvertToPurity(xPosition, yPosition);
                        }
                    }
                }
            }
            return base.PreKill(projectile, timeLeft);
        }
        public static void ConvertToPurity(int x, int y)
        {
            if (!WorldGen.InWorld(x, y, 1))
                return;

            Tile tile = Framing.GetTileSafely(x, y);

            if (!tile.HasTile)
                return;

            if (WallID.Sets.Conversion.Grass[tile.WallType] && tile.WallType != WallID.Grass)
            {
                tile.WallType = WallID.Grass;
                WorldGen.SquareWallFrame(x, y);
                NetMessage.SendTileSquare(-1, x, y, 1);
            }
            if ((TileID.Sets.Conversion.Stone[tile.TileType] || TileID.Sets.Conversion.Moss[tile.TileType]) && tile.TileType != TileID.Stone)
            {
                tile.TileType = TileID.Stone;
                WorldGen.SquareTileFrame(x, y);
                NetMessage.SendTileSquare(-1, x, y, 1);
            }
            if (TileID.Sets.Conversion.Dirt[tile.TileType] && tile.TileType != TileID.Dirt)
            {
                tile.TileType = TileID.Dirt;
                WorldGen.SquareTileFrame(x, y);
                NetMessage.SendTileSquare(-1, x, y, 1);
            }
            else if (TileID.Sets.Conversion.Grass[tile.TileType] && tile.TileType != TileID.Grass)
            {
                tile.TileType = TileID.Grass;
                WorldGen.SquareTileFrame(x, y);
                NetMessage.SendTileSquare(-1, x, y, 1);
            }
            else if (TileID.Sets.Conversion.Sand[tile.TileType] && tile.TileType != TileID.Sand)
            {
                tile.TileType = TileID.Sand;
                WorldGen.SquareTileFrame(x, y);
                NetMessage.SendTileSquare(-1, x, y, 1);
            }
            else if (TileID.Sets.Conversion.Ice[tile.TileType] && tile.TileType != TileID.IceBlock)
            {
                tile.TileType = TileID.IceBlock;
                WorldGen.SquareTileFrame(x, y);
                NetMessage.SendTileSquare(-1, x, y, 1);
            }
        }
    }
}