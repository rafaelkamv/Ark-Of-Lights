using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;

namespace ArkOfLights.Content.Items.Material
{
    public class CrystallizeEternity : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A material that seems to\nhave crystallize for a long time\n[c/04c3f9:Mythic Material]");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 99;
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.rare = ItemRarityID.Pink;
            Item.maxStack = 999;
            Item.value = Item.sellPrice(platinum: 10);
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
