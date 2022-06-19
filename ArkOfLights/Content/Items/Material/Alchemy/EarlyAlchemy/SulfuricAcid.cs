using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;

namespace ArkOfLights.Content.Items.Material.Alchemy.EarlyAlchemy
{
    public class SulfuricAcid : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Liquid version of Sulfur, DO NOT DRINK!\n[c/F4F4F4:Common Material]");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 26;
            Item.useStyle = ItemUseStyleID.DrinkLiquid;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useTurn = true;
            Item.UseSound = SoundID.Item3;
            Item.consumable = true;
            Item.buffType = BuffID.Poisoned;
            Item.buffTime = 300;

            Item.maxStack = 999;
            Item.value = Item.sellPrice(silver: 2, copper: 2);
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<Items.Material.Alchemy.EarlyAlchemy.Sulfur>(2);
            recipe.AddIngredient(ItemID.Bottle);
            recipe.AddTile<Tiles.Furniture.CraftingStation.AlchemicalTable>();
            recipe.Register();
        }
    }
}
