using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.Calamity.AccessorySlots
{
    public class AstrumDeus : ModAccessorySlot
    {
        public override bool IsEnabled() => CalamityConfiguration.I.enableAstrumDeusAccessorySlot &&
                                            Calamity.CheckDowned("astrumdeus");

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}