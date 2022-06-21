using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;

namespace ArkOfLights.Content.Items.Material.Alchemy.EarlyAlchemy
{
    public class AbsoluteFuel : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Used to fuel almost everything\n[c/8686E5:Rare Material]");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.rare = ItemRarityID.Blue;

            Item.maxStack = 999;
            Item.value = Item.sellPrice(silver: 75);
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Hellstone, 4);
            recipe.AddIngredient<Items.Material.Alchemy.EarlyAlchemy.Charcoal>(2);
            recipe.AddCondition(Recipe.Condition.InGraveyardBiome);
            recipe.AddTile<Tiles.Furniture.CraftingStation.AlchemicalTable>();
            recipe.Register();
        }
    }
}
