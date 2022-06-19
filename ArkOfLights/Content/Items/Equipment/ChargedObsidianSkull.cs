using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace ArkOfLights.Content.Items.Equipment
{
    public class ChargedObsidianSkull : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Charged Obsidian Skull");
            Tooltip.SetDefault("Grants immunity to fire blocks\n[c/8686E5:Rare Accessory]");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.ObsidianSkull);
            Item.width = 32;
            Item.height = 32;
            Item.rare = ItemRarityID.Blue;
            Item.defense = 3;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.ObsidianSkull);
            recipe.AddIngredient<Items.Material.Alchemy.EarlyAlchemy.ChargedPowder>(4);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}
