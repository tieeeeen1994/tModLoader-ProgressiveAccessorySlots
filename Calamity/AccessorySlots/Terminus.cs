using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.Calamity.AccessorySlots
{
    public class Terminus : ModAccessorySlot
    {
        public override bool IsEnabled() => CalamityConfiguration.I.enableBossRushAccessorySlot &&
                                            Calamity.CheckDowned("terminus");

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}