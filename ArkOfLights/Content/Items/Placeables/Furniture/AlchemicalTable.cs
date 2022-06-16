using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace ArkOfLights.Content.Items.Placeables.Furniture
{
    public class AlchemicalTable : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Alchemical Table");
            Tooltip.SetDefault("Used to do Alchemy\n[c/F4F4F4:Common Crafting Station]");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.createTile = ModContent.TileType<Tiles.Furniture.CraftingStation.AlchemicalTable>();

            Item.width = 30;
            Item.height = 32;

            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 10;
            Item.useAnimation = 15;
            Item.rare = 1;

            Item.maxStack = 99;
            Item.consumable = true;
            Item.value = 0;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddRecipeGroup("IronBar", 6);
            recipe.AddIngredient(ItemID.Bottle, 1);
            recipe.AddRecipeGroup("Wood", 12);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
            
        }
    }
}
