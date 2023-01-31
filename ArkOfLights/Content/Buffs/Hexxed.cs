using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ArkOfLights.Content.Buffs
{
    
    public class Frostburn : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hexxed");
            Description.SetDefault("You're sealed");
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
            BuffID.Sets.LongerExpertDebuff[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<HexxedPlayer>().Hexxed= true;
            player.statDefense -= 10;
        }
    }

    public class HexxedPlayer : ModPlayer
    {
        public bool Hexxed;

        public override void ResetEffects()
        {
            Hexxed = false;
        }

        public override void UpdateBadLifeRegen()
        {
            if (Hexxed)
            {
                if (Player.lifeRegen > 0)
                    Player.lifeRegen = 0;

                Player.lifeRegenTime = 0;

                Player.lifeRegen -= 6660;
            }
        }
    }
}
