using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ArkOfLights.Content.Buffs
{
    
    public class Frostburn : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Frostburn");
            Description.SetDefault("You're burning while Freezing");
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
            BuffID.Sets.LongerExpertDebuff[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<FrostburnPlayer>().Frostburn= true;
        }
    }

    public class FrostburnPlayer : ModPlayer
    {
        public bool Frostburn;

        public override void ResetEffects()
        {
            Frostburn = false;
        }

        public override void UpdateBadLifeRegen()
        {
            if (Frostburn)
            {
                if (Player.lifeRegen > 0)
                    Player.lifeRegen = 0;

                Player.lifeRegenTime = 0;

                Player.lifeRegen -= 18;
            }
        }
    }
}
