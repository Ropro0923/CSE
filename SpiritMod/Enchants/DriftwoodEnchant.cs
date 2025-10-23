namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class DriftwoodEnchant : BaseEnchant
    {
        public override Color nameColor => new(186, 154, 114);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.rare = ItemRarityID.White;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddEffect<DriftwoodEffect>(Item);
        }
        public class DriftwoodEffect : AccessoryEffect
        {
            public override Header ToggleHeader => null;
            public override int ToggleItemType => ModContent.ItemType<DriftwoodEnchant>();
        }
    }
}