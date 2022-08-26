using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace ArkOfLights.Content.Items.Weapons
{
    public class AncientVolcanicSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Forged from the hottest material made\n[c/8686E5:Rare Sword]");
        }

        public override void SetDefaults()
        {
            Item.damage = 74;
            Item.DamageType = DamageClass.Melee;
            Item.crit = 0;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 18;
            Item.useAnimation = 20;
            Item.useStyle = 1;
            Item.knockBack = 8;
            //Item.value = 1;
            Item.rare = ItemRarityID.Blue;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            target.AddBuff(BuffID.OnFire, 120);
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<Items.Material.Alchemy.EarlyAlchemy.VolcanicEruption>(20);
            recipe.AddIngredient<Items.Material.Alchemy.EarlyAlchemy.Sulfur>(20);
            recipe.AddIngredient(ItemID.Gel, 99);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}
