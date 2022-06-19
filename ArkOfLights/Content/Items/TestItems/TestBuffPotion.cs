using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace ArkOfLights.Content.Items.TestItems
{
    public class TestBuffPotion : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("This is a Debug/Testing item\nYou shouldn't be able to get this normaly");
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
            Item.maxStack = 20;
            Item.consumable = true;
            Item.rare = -12;
            Item.buffType = ModContent.BuffType<Content.Buffs.Frostburn>();
            Item.buffTime = 300;
        }
    }
}
