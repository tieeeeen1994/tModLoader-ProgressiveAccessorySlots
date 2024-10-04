using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.Calamity.AccessorySlots
{
    public class AcidRainTwo : ModAccessorySlot
    {
        public override bool IsEnabled() => CalamityConfiguration.I.enableAcidRainTwoAccessorySlot &&
                                            Calamity.CheckDowned("acidrain2");

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}