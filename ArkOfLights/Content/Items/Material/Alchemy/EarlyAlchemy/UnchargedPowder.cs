using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;

namespace ArkOfLights.Content.Items.Material.Alchemy.EarlyAlchemy
{
    public class UnchargedPowder : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Used in the crafting of Weapons\n[c/92F892:Uncommon Material]");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 99;
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.rare = ItemRarityID.Green;

            Item.maxStack = 99;
            Item.value = Item.sellPrice(silver: 10);
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<Items.Material.Alchemy.EarlyAlchemy.Charcoal>(4);
            recipe.AddIngredient<Items.Material.Alchemy.EarlyAlchemy.Sulfur>();
            recipe.AddTile<Tiles.Furniture.CraftingStation.AlchemicalTable>();
            recipe.Register();
        }
    }
}
