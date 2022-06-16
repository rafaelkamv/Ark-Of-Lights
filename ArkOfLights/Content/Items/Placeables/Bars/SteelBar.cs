using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace ArkOfLights.Content.Items.Placeables.Bars
{
    public class SteelBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A very durable Ingot\n[c/92F892:Uncommon Material]");
            //add Tile later
        }

        public override void SetDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 99;
            ItemID.Sets.SortingPriorityMaterials[Item.type] = 57;
            Item.maxStack = 99;
            Item.rare = ItemRarityID.Green;
            Item.width = 30;
            Item.height = 24;
            Item.value = 1005;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.autoReuse = true;
            Item.placeStyle = 1;
        }
        public override void OnResearched(bool fullyResearched)
        {
            if (fullyResearched)
            {
                CreativeUI.ResearchItem(ModContent.ItemType<SteelBar>());
            }
        }

        //Recipes
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddRecipeGroup("IronBar", 2);
            recipe.AddIngredient(ItemID.Gel, 1);
            recipe.AddTile(TileID.Furnaces);
            recipe.Register();
        }
    }
}
