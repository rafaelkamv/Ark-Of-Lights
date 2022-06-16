using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace ArkOfLights.Content.Tiles.Furniture.CraftingStation
{
    public class AlchemicalTable : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileTable[Type] = true;
            Main.tileSolidTop[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            Main.tileFrameImportant[Type] = true;
            TileID.Sets.DisableSmartCursor[Type] = true;
            TileID.Sets.IgnoredByNpcStepUp[Type] = true;

            AdjTiles = new int[] { TileID.AlchemyTable };

            //Placing
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            TileObjectData.newTile.CoordinateHeights = new[] { 32, 34 };
            TileObjectData.addTile(Type);

            //Stuff
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Alchemical Table");
            AddMapEntry(new Color(28, 187, 200), name);
        }

        public override void NumDust(int x, int y, bool fail, ref int num)
        {
            num = fail ? 1 : 3;
        }

        public override void KillMultiTile(int x, int y, int frameX, int frameY)
        {
            Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 15, 32, 16, ModContent.ItemType<Items.Placeables.Furniture.AlchemicalTable>());
        }
    }
}
