using ResonantSouls.Content.Tiles;

namespace ResonantSouls.Content.Items.Placeables.Paintings
{
    public class ResonantSoulsPainting : ModItem
    {
        public override string Texture => $"{Mod.Name}/icon";
        public override void SetDefaults()
        {
            Item.width = Item.height = 80;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.value = Item.buyPrice(0, 2, 0, 0);
            Item.rare = ItemRarityID.White;
            Item.createTile = ModContent.TileType<ResonantSoulsPaintingTile>();
        }
        // Thanks to Akira, I don't know how to do this myself. If you have problems with me doing this, I'll figure out how to do it myself     - Ropro0923
        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            if (!Main.keyState.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.LeftShift))
                return;

            string tooltip = "";

            int namesPerLine = 6;
            for (int i = 0; i < Devs.Count; i++)
            {
                tooltip += Devs[i];

                if (i == Devs.Count - 1)
                    break;

                if (i % namesPerLine == 0 && i != 0)
                    tooltip += "\n";
                else
                    tooltip += ", ";
            }
            tooltip += "\n";

            int teamsPerLine = 3;
            for (int i = 0; i < Teams.Count; i++)
            {
                tooltip += Teams[i];

                if (i == Teams.Count - 1)
                    break;

                if (i % teamsPerLine == 0 && i != 0)
                    tooltip += "\n";
                else
                    tooltip += ", ";
            }

            TooltipLine line = tooltips.FirstOrDefault(t => t.Mod == "Terraria" && t.Name == "Tooltip1");
            if (line != null)
                line.Text = tooltip;
        }

        internal static IList<string> Devs =
        [
            "Ropro0923",
            "Leo",
            "IceSpider",
            "Mr. Puzzles",
            "Akira",
            "StarlightCat",
            "Advantaje",
            "WardrobeHummus",
            "Ma3allim",
            "DanHameln",
            "Cheesenuggets",
            "Soltan",
            "magegor11",
            "Vergenum",
            "aizen522",
            "Tyr",
            "and Yob",
        ];

        internal static IList<string> Teams =
        [
            "And special thanks to the Infernal Eclipse of Ragnarok team",
            "the Community Souls Expansion team",
            "the Fargos team",
            "the Spirit team",
            "and to everyone who plays this mod!",
        ];
    }
}