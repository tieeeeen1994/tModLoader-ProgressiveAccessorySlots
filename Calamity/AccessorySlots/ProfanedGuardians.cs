using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.Calamity.AccessorySlots
{
    public class ProfanedGuardians : ModAccessorySlot
    {
        public override bool IsEnabled() => CalamityConfiguration.I.enableProfanedGuardianAccessorySlot &&
                                            Calamity.CheckDowned("profanedguardians");

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}