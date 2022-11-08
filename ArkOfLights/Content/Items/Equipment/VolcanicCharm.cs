using MonoMod.Cil;
using System;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Mono.Cecil.Cil;

namespace ArkOfLights.Content.Items.Equipment
{
    [AutoloadEquip(EquipType.Neck)]
    public class VolcanicCharm : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Provides 14 seconds of immunity to lava\n[c/b227fd:Epic Accessory]");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            sbyte realNeckSlot = Item.neckSlot;
            Item.CloneDefaults(ItemID.LavaCharm);
            Item.width = 32;
            Item.height = 32;
            Item.value = Item.buyPrice(gold: 5);
            Item.rare = 11;
            Item.accessory = true;

            Item.defense = 3;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.lavaMax = 840;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.LavaCharm);
            recipe.AddIngredient(ItemID.HellstoneBar, 18);
            recipe.AddIngredient<Items.Material.Alchemy.EarlyAlchemy.AbsoluteFuel>(60);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}
