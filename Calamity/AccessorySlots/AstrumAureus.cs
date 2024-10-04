using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.Calamity.AccessorySlots
{
    public class AstrumAureus : ModAccessorySlot
    {
        public override bool IsEnabled() => CalamityConfiguration.I.enableAstrumAureusAccessorySlot &&
                                            Calamity.CheckDowned("astrumaureus");

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}