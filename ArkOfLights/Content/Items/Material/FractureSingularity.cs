using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;

namespace ArkOfLights.Content.Items.Material
{
    public class EssenceofClarity : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fractured Singularity");
            Tooltip.SetDefault("Main component in the making of Singularities\n[c/04c3f9:Epic Material]");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 99;
        }

        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;
            Item.rare = ItemRarityID.Purple;
            Item.maxStack = 1;
        }

        public override void OnResearched(bool fullyResearched)
        {
            if (fullyResearched)
            {
                CreativeUI.ResearchItem(ModContent.ItemType<FracturedSingularity>());
            }
        }
    }
}
