using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace ArkOfLights.Content.Items.Weapons
{
    public class FancySword : ModItem
    {

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("It's so fancy it lights your enemies on fire!");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            //Attack
            Item.damage = 7;
            Item.crit = 0;
            Item.knockBack = 6;
            Item.autoReuse = true;

            //Others
            Item.DamageType = DamageClass.Melee;
            Item.useAnimation = 12;
            Item.useTime = 12;
            Item.width = 16;
            Item.height = 16;
            Item.rare = ItemRarityID.Green;
            Item.UseSound = SoundID.Item1;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.value = Item.sellPrice(0);
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.SilverBar, 24);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            target.AddBuff(BuffID.Frostburn, 300);
        }
    }
}
