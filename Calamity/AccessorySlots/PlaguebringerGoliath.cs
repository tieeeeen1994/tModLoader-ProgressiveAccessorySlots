using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.Calamity.AccessorySlots
{
    public class PlaguebringerGoliath : ModAccessorySlot
    {
        public override bool IsEnabled() => CalamityConfiguration.I.enablePlaguebringerGoliathAccessorySlot &&
                                            Calamity.CheckDowned("plaguebringergoliath");

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}