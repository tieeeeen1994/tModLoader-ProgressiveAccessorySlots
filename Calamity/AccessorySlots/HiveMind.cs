using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.Calamity.AccessorySlots
{
    public class HiveMind : ModAccessorySlot
    {
        public override bool IsEnabled() => CalamityConfiguration.I.enableHiveMindAccessorySlot &&
                                            Calamity.CheckDowned("hivemind");

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}