using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.Calamity.AccessorySlots
{
    public class SupremeCalamitas : ModAccessorySlot
    {
        public override bool IsEnabled() => CalamityConfiguration.I.enableSupremeCalamitasAccessorySlot &&
                                            Calamity.CheckDowned("supremecalamitas");

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}