using FargowiltasSouls.Content.Items;
using FargowiltasSouls.Content.Items.Accessories.Forces;

namespace ResonantSouls.Common
{
    public class EnchantPricesSystem : ModSystem
    {
        public override void PostSetupContent()
        {
            foreach (var item in ModContent.GetContent<ModItem>())
            {
                if (item is BaseEnchant && ResonantSouls.Instance.TryFind($"{item.Name}", out ModItem enchant))
                {
                    SoulsPrices.Enchants.Add(enchant.Type);
                }
                else if (item is BaseForce && ResonantSouls.Instance.TryFind($"{item.Name}", out ModItem force))
                {
                    SoulsPrices.Enchants.Add(force.Type);
                }
                else if (item is SoulsItem && ResonantSouls.Instance.TryFind($"{item.Name}", out ModItem SoulsItem))
                {
                    SoulsPrices.Enchants.Add(SoulsItem.Type);
                }
            }
        }
    }
    public class SoulsPrices : GlobalItem
    {
        internal static List<int> Enchants = [];
        public override void SetDefaults(Item item)
        {
            foreach (var enchant in Enchants)
            {
                if (item.type == enchant)
                {
                    foreach (var recipe in Main.recipe)
                    {
                        if (recipe is null || recipe.createItem.type != item.type)
                            continue;

                        foreach (var ingredient in recipe.requiredItem)
                        {
                            item.value += ingredient.value * ingredient.stack;
                        }
                    }
                }
            }
        }
    }
}