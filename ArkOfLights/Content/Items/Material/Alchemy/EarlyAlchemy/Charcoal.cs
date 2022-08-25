using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;

namespace ArkOfLights.Content.Items.Material.Alchemy.EarlyAlchemy
{
    public class Charcoal : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Burnt Wood\n[c/F4F4F4:Common Material]");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 99;
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.rare = 1;

            Item.maxStack = 99;
            Item.value = Item.sellPrice(silver: 1);
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddRecipeGroup("Wood", 2);
            recipe.AddTile(TileID.Furnaces);
            recipe.Register();
        }
    }
}
