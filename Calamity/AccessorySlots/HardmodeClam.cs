using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.Calamity.AccessorySlots
{
    public class HardmodeClam : ModAccessorySlot
    {
        public override bool IsEnabled() => CalamityConfiguration.I.enableHardmodeClamAccessorySlot &&
                                            Calamity.CheckDowned("hmclam");

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}