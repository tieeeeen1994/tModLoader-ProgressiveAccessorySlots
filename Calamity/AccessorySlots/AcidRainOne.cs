using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.Calamity.AccessorySlots
{
    public class AcidRainOne : ModAccessorySlot
    {
        public override bool IsEnabled() => CalamityConfiguration.I.enableAcidRainOneAccessorySlot &&
                                            Calamity.CheckDowned("acidrain1");

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}