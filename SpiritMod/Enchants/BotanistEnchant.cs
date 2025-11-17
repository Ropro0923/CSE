using FargowiltasSouls.Core.Toggler.Content;
using SpiritMod.Items.Armor.BotanistSet;
using SpiritMod.Items.Sets.BriarDrops;
using SpiritMod.Items.Sets.ClubSubclass;
using SpiritMod.Items.Sets.ToolsMisc.Evergreen;
using ResonantSouls.SpiritMod.Core;
using SpiritMod.Tiles.Ambient.Forest;
using Terraria.DataStructures;
using SpiritMod.Items.ByBiome.Forest.Placeable.Decorative;

namespace ResonantSouls.SpiritMod.Enchants
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class BotanistEnchant : BaseEnchant
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Color nameColor => new(206, 182, 95);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.width = 36;
            Item.height = 36;
            Item.rare = ModContent.GetInstance<BotanistHat>().Item.rare;
            Item.value = ModContent.GetInstance<BotanistHat>().Item.value + ModContent.GetInstance<BotanistBody>().Item.value + ModContent.GetInstance<BotanistLegs>().Item.value + ModContent.GetInstance<WoodenClub>().Item.value + ModContent.GetInstance<UnfellerOfEvergreens>().Item.value + ModContent.GetInstance<ReachFishingCatch>().Item.value;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddEffect<BotanistEffect>(Item);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<BotanistHat>()
                .AddIngredient<BotanistBody>()
                .AddIngredient<BotanistLegs>()
                .AddIngredient<WoodenClub>()
                .AddIngredient<UnfellerOfEvergreens>()
                .AddIngredient<ReachFishingCatch>()
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class BotanistEffect : AccessoryEffect
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override Header ToggleHeader => Header.GetHeader<WorldShaperHeader>();
        public override int ToggleItemType => ModContent.ItemType<BotanistEnchant>();
        public override void PostUpdate(Player player)
        {
            ModContent.Find<ModItem>(ModCompatibility.SpiritMod.Name, "BotanistHat").UpdateArmorSet(player);
            ModContent.Find<ModItem>(ModCompatibility.SpiritMod.Name, "BotanistBody").UpdateArmorSet(player);
            ModContent.Find<ModItem>(ModCompatibility.SpiritMod.Name, "BotanistLegs").UpdateArmorSet(player);
        }
    }
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class BotanistHerb : GlobalTile
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override void Drop(int i, int j, int type)
        {
            if (type == ModContent.TileType<Cloudstalk>() || type == TileID.MatureHerbs)
            {
                List<int> items =
                [
                    ItemID.Daybloom,
                    ItemID.Moonglow,
                    ItemID.Blinkroot,
                    ItemID.Waterleaf,
                    ItemID.Deathweed,
                    ItemID.Fireblossom,
                    ItemID.Shiverthorn,
                    ModContent.ItemType<CloudstalkItem>(),
                ];
                for (int herbCount = 0; herbCount < Main.rand.Next(4); herbCount++)
                {
                    int herb = Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 16, 16, items[Main.rand.Next(items.Count)]);
                    if (Main.netMode == NetmodeID.MultiplayerClient)
                        NetMessage.SendData(MessageID.SyncItem, -1, -1, null, herb, 1f);
                }
            }
        }
    }
}