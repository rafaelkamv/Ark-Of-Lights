using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ArkOfLights.Content.Buffs
{
    
    public class Frostburn : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Absolute Defragmentation");
            Description.SetDefault("Fatal");
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
            BuffID.Sets.LongerExpertDebuff[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<AbsoluteDefragmentationPlayer>().AbsoluteDefragmentation= true;
            player.statDefense -= 25;
        }
    }

    public class AbsoluteDefragmentationPlayer : ModPlayer
    {
        public bool AbsoluteDefragmentation;

        public override void ResetEffects()
        {
            AbsoluteDefragmentation = false;
        }

        public override void UpdateBadLifeRegen()
        {
            if (AbsoluteDefragmentation)
            {
                if (Player.lifeRegen > 0)
                    Player.lifeRegen = 0;

                Player.lifeRegenTime = 0;

                Player.lifeRegen -= 32;
            }
        }
    }
}
