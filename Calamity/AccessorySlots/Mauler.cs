using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.Calamity.AccessorySlots
{
    public class Mauler : ModAccessorySlot
    {
        public override bool IsEnabled() => CalamityConfiguration.I.enableMaulerAccessorySlot &&
                                            Calamity.CheckDowned("mauler");

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}