using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;

namespace ArkOfLights.Content.Items.Material.Alchemy.AdvanceAlchemy
{
    public class OverchargedSulfur : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("When you combined Charged Powder and Sulfur\nit made this.\nCAUTION, can probably explode\n[c/8686E5:Rare Material]");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 99;
        }

        public override void SetDefaults()
        {
            Item.width = 64;
            Item.height = 48;

            Item.maxStack = 99;
            Item.value = Item.sellPrice(silver: 30);
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<Items.Material.Alchemy.EarlyAlchemy.ChargedPowder>(2);
            recipe.AddIngredient<Items.Material.Alchemy.EarlyAlchemy.Sulfur>(1);
            recipe.AddTile<Tiles.Furniture.CraftingStation.AlchemicalTable>();
            recipe.Register();
        }
    }
}
