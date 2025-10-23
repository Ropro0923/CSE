namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class ElderbarkEnchant : BaseEnchant
    {
        public override Color nameColor => new(115, 141, 54);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.rare = ItemRarityID.White;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddEffect<ElderbarkEffect>(Item);
        }
        public class ElderbarkEffect : AccessoryEffect
        {
            public override Header ToggleHeader => null;
            public override int ToggleItemType => ModContent.ItemType<ElderbarkEnchant>();
        }
    }
}