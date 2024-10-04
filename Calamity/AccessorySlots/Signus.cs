using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.Calamity.AccessorySlots
{
    public class Signus : ModAccessorySlot
    {
        public override bool IsEnabled() => CalamityConfiguration.I.enableSignusAccessorySlot &&
                                            Calamity.CheckDowned("signus");

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}