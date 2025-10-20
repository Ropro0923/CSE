namespace ResonantSouls
{
    public class Debug
    {
        internal static string Placeholder = "FargowiltasSouls/Content/Items/Placeholder";
    }
    public class DebugItem : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            TooltipLine Value = new(Mod, "Value", "Value: " + item.value.ToString())
            {
                OverrideColor = Color.Green
            };
            tooltips.Add(Value);

            TooltipLine Rare = new(Mod, "Rarity", "Rarity: " + item.rare.ToString())
            {
                OverrideColor = Color.Cyan
            };
            tooltips.Add(Rare);

            TooltipLine Name = new(Mod, "Name", "Name: " + ItemID.Search.GetName(item.type))
            {
                OverrideColor = Color.Purple
            };
            tooltips.Add(Name);
        }
    }
}