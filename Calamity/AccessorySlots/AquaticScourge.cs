using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.Calamity.AccessorySlots
{
    public class AquaticScourge : ModAccessorySlot
    {
        public override bool IsEnabled() => CalamityConfiguration.I.enableAquaticScourgeAccessorySlot &&
                                            Calamity.CheckDowned("aquaticscourge");

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}