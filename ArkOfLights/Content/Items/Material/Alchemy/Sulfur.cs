using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;

namespace ArkOfLights.Content.Items.Material.Alchemy
{
    public class Sulfur : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The most basic form of Alchemy\n[c/F4F4F4:Common Material]");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 99;
        }

        public override void SetDefaults()
        {
            Item.width = 64;
            Item.height = 48;

            Item.maxStack = 99;
            Item.value = Item.sellPrice(silver: 3);
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<Items.Material.Alchemy.Charcoal>(2);
            recipe.AddIngredient(ItemID.BottledWater);
            recipe.AddTile<Tiles.Furniture.CraftingStation.AlchemicalTable>();
            recipe.Register();
        }
    }
}
