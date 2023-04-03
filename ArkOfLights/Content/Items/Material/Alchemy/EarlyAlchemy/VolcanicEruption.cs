using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;

namespace ArkOfLights.Content.Items.Material.Alchemy.EarlyAlchemy
{
    public class VolcanicEruption : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A very hot material\n[c/92F892:Uncommon Material]");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 999;
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.rare = ItemRarityID.Green;

            Item.maxStack = 999;
            Item.value = Item.sellPrice(gold: 1);
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.HellstoneBar, 4);
            recipe.AddIngredient<Items.Material.Alchemy.EarlyAlchemy.AbsoluteFuel>();
            recipe.AddTile(TileID.Hellforge);
            recipe.Register();
        }
    }
}
