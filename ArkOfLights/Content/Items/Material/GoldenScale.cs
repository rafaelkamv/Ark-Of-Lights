using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;

namespace ArkOfLights.Content.Items.Material
{
    public class GoldenScale : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Delicate scales made from gold\n[c/8686E5:Rare Material]");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 999;
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.rare = ItemRarityID.Blue;
            Item.maxStack = 999;
            Item.value = Item.sellPrice(gold: 3);
        }

          // Placeholder crafting recipe
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.GoldBar, 3)
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.Register();
         }
        
        public override void OnResearched(bool fullyResearched)
        {
            if (fullyResearched)
            {
                CreativeUI.ResearchItem(ModContent.ItemType<GoldenScale>());
            }
        }
    }
}
