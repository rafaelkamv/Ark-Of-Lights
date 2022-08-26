using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using Terraria.ModLoader;

namespace ArkOfLights.Common
{
    public class ModIntergrationSystem : ModSystem
    {
        public override void PostSetupContent()
        {
            DoTheStarsAboveIntergration();
            DoBossChecklistIntegration();
        }

        private void DoTheStarsAboveIntergration()
        {
            if (!ModLoader.TryGetMod("TheStarsAbove", out Mod TheStarsAboveMod))
            {
                return;
            }
        }

        private void DoBossChecklistIntegration()
        {
            if (!ModLoader.TryGetMod("BossChecklist", out Mod bossChecklistMod))
            {
                return;
            }

            if (bossChecklistMod.Version < new Version(1, 3, 1))
            {
                return;
            }
        }
    }
}
