using FargowiltasSouls;
using FargowiltasSouls.Content.Items.Summons;
using Terraria.Localization;

namespace ResonantSouls.Content.Items.Consumables.Summons
{
    public class SigilOfResonance : SigilOfChampions
    {
        public override string Texture => $"{Mod.Name}/Assets/Textures/Content/Items/Consumables/Summons/SigilOfResonance";
        private void PrintChampMessage(string key)
        {
            Main.NewText(Language.GetTextValue($"Mods.{Mod.Name}.Items.SigilOfResonance.Message.{key}"), new Color(175, 75, 255));
        }
        public override bool? UseItem(Player player)
        {
            if (ModCompatibility.SpiritMod.Loaded)
            {
                ModContent.TryFind("SpiritMod", "BriarSurfaceBiome", out ModBiome briarBiome);
                if (player.InModBiome(briarBiome))
                {
                    if (player.altFunctionUse == 2)
                        PrintChampMessage("Etheriality");
                    else
                        FargoSoulsUtil.SpawnBossNetcoded(player, ModContent.Find<ModNPC>("EtherialityChampion").Type);
                }
                return true;
            }
            if (player.altFunctionUse == 2)
                PrintChampMessage("Nothing");
            return true;
        }
    }
}