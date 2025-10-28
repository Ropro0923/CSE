using FargowiltasSouls.Content.Items.Accessories.Souls;
using ResonantSouls.SpiritMod.Enchants;
using ResonantSouls.SpiritMod.Souls;

namespace ResonantSouls.SpiritMod.Core
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class SpiritModRecipesAndEffectsSystem : ModSystem
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override void PostAddRecipes()
        {
            foreach (var Recipe in Main.recipe)
            {
                if (Recipe.createItem.type == ModContent.ItemType<EternitySoul>())
                {
                    Recipe.AddIngredient<EtherealitySoul>();
                }
                else if (Recipe.createItem.type == ModContent.ItemType<WorldShaperSoul>())
                {
                    Recipe.AddIngredient<BotanistEnchant>();
                }
                else if (Recipe.createItem.type == ModContent.ItemType<TrawlerSoul>())
                {
                    Recipe.AddIngredient<DriftwoodEnchant>();
                }
            }
        }
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class SpiritModRecipesAndEffectsGlobalItem : GlobalItem
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override void UpdateAccessory(Item item, Player player, bool hideVisual)
        {
            if (item.type == ModContent.ItemType<EternitySoul>())
            {
                ModContent.GetInstance<EtherealitySoul>().UpdateAccessory(player, hideVisual);
            }
            else if (item.type == ModContent.ItemType<WorldShaperSoul>())
            {
                ModContent.GetInstance<BotanistEnchant>().UpdateAccessory(player, hideVisual);
            }
            else if (item.type == ModContent.ItemType<TrawlerSoul>())
            {
                ModContent.GetInstance<DriftwoodEnchant>().UpdateAccessory(player, hideVisual);
            }
        }
        public override void SetDefaults(Item entity)
        {
            if (entity.type == ModContent.ItemType<EternitySoul>())
            {
                entity.value += ModContent.GetInstance<EtherealitySoul>().Item.value;
            }
            else if (entity.type == ModContent.ItemType<WorldShaperSoul>())
            {
                entity.value += ModContent.GetInstance<BotanistEnchant>().Item.value;
            }
            else if (entity.type == ModContent.ItemType<TrawlerSoul>())
            {
                entity.value += ModContent.GetInstance<DriftwoodEnchant>().Item.value;
            }
        }
    }
}