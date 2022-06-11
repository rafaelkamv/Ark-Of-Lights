using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace ArkOfLights.Content.Items.Placeables.Bars
{
    public class RoyalGold : ModItem
    {
        public override void SetDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 99;
            ItemID.Sets.SortingPriorityMaterials[Item.type] = 59;
            Item.maxStack = 99;
            Item.rare = ItemRarityID.Blue;
            Item.width = 32;
            Item.height = 32;
            Item.value = 3000;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.autoReuse = true;
            Item.consumable = true;
            Item.placeStyle = 1;
        }

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A more durable Gold Bar, Infused with Steel\n\n[c/8686E5:Rare Material]");
            Item.createTile = ModContent.TileType<Tiles.RoyalGold>();
        }

        public override void OnResearched(bool fullyResearched)
        {
            if (fullyResearched)
            {
                CreativeUI.ResearchItem(ModContent.ItemType<RoyalGold>());
            }
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.GoldBar, 1);
            recipe.AddIngredient<Items.Placeables.Bars.SteelBar>();
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}
