using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ArkOfLights.Content.Buffs
{
    
    public class Pyrobleed : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pyrobleed");
            Description.SetDefault("Extra hot");
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
            BuffID.Sets.LongerExpertDebuff[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<PyrobleedPlayer>().Pyrobleed= true;
        }
    }

    public class PyrobleedPlayer : ModPlayer
    {
        public bool Pyrobleed;

        public override void ResetEffects()
        {
            Pyrobleed = false;
        }

        public override void UpdateBadLifeRegen()
        {
            if (Pyrobleed)
            {
                if (Player.lifeRegen > 0)
                    Player.lifeRegen = 0;

                Player.lifeRegenTime = 0;

                Player.lifeRegen -= 24;
            }
        }
    }
}
