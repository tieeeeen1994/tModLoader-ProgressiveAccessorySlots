using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.Calamity.AccessorySlots
{
    public class DesertScourge : ModAccessorySlot
    {
        public override bool IsEnabled() => CalamityConfiguration.I.enableDesertScourgeAccessorySlot &&
                                            Calamity.CheckDowned("desertscourge");

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}