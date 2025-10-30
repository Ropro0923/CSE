using Luminance.Assets;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace ResonantSouls.Core
{
    public class ResonantSoulsUtilities
    {
        public static LazyAsset<Texture2D> GetEnchantTexture(string Enchant)
        {
            return LazyAsset<Texture2D>.Request($"ResonantSouls/Assets/Textures/Content/Items/Accessories/Enchantments/{Enchant}", AssetRequestMode.AsyncLoad);
        }
    }
}