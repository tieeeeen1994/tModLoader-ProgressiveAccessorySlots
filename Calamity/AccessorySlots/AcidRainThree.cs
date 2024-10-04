using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.Calamity.AccessorySlots
{
    public class AcidRainThree : ModAccessorySlot
    {
        public override bool IsEnabled() => CalamityConfiguration.I.enableAcidRainThreeAccessorySlot &&
                                            Calamity.CheckDowned("acidrain3");

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}