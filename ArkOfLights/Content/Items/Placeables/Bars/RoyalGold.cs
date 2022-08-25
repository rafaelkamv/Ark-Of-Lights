using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace ArkOfLights.Content.Items.Placeables.Bars
{
    public class RoyalGold : ModItem
    {
        
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A more durable Gold Bar, Infused with Steel Bar\n\n[c/8686E5:Rare Material]");
            Item.createTile = ModContent.TileType<Tiles.RoyalGold>();
        }
        
        public override void SetDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 99;
            ItemID.Sets.SortingPriorityMaterials[Item.type] = 59;
            Item.maxStack = 999;
            Item.rare = ItemRarityID.Blue;
            Item.width = 30;
            Item.height = 24;
            Item.value = 7895;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.consumable = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.autoReuse = true;
            Item.placeStyle = 1;
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
            recipe.AddIngredient<Items.Placeables.Bars.SteelBar>(2);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}
