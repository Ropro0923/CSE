using System.Collections.Generic;
using SOR.SpiritMod.Enchants;

namespace SOR
{
    public class Debug : ModPlayer
    {
        internal static string Placeholder = "SOR/Placeholder";
        public override void OnEnterWorld()
        {
            int cascadeItemType = ModContent.ItemType<CascadeEnchant>();
            int totalValue = 0;
            List<int> ingredients = new();

            foreach (var recipe in Main.recipe)
            {
                if (recipe == null)
                    continue;

                if (recipe.createItem.type != cascadeItemType)
                    continue;

                if (recipe.requiredItem == null || recipe.requiredItem.Count == 0)
                    continue;

                foreach (var ingredient in recipe.requiredItem)
                {
                    if (ingredient != null && ingredient.type > ItemID.None)
                        ingredients.Add(ingredient.type);
                }
            }

            foreach (int type in ingredients)
            {
                Item temp = new Item();
                temp.SetDefaults(type);
                totalValue += temp.value;
            }

            Main.NewText(totalValue);
        }
    }
}
