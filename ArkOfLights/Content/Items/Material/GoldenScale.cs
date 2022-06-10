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
            Tooltip.SetDefault("Used to Craft the Golden Scale Armor set\n[c/8686E5:Rare Material");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 64;
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.rare = ItemRarityID.Blue;
            Item.maxStack = 64;
            Item.value = Item.sellPrice(gold: 3);
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
