using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace ArkOfLights.Content.Items.Placeables.Bars
{
    public class FoolsGold : ModItem
    {
        
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fool's Gold");
            Tooltip.SetDefault("A rarer arch type of gold\nimbued with some sulfur to make\n[c/8686E5:Rare Material]");
            // Remind me to add a tile
            // Item.createTile = ModContent.TileType<Tiles.FoolsGold>();
        }
        
        public override void SetDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 99;
            ItemID.Sets.SortingPriorityMaterials[Item.type] = 59;
            Item.maxStack = 999;
            Item.rare = ItemRarityID.Blue;
            Item.width = 30;
            Item.height = 24;
            Item.value = Item.sellPrice(gold: 7);
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
                CreativeUI.ResearchItem(ModContent.ItemType<FoolsGold>());
            }
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.GoldBar, 2);
            recipe.AddIngredient<Items.Material.Alchemy.EarlyAlchemy.Sulfur>(4);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}
