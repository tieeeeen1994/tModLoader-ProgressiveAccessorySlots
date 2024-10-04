using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.Calamity.AccessorySlots
{
    public class CalamitasClone : ModAccessorySlot
    {
        public override bool IsEnabled() => CalamityConfiguration.I.enableCalamitasCloneAccessorySlot &&
                                            Calamity.CheckDowned("calamitasclone");

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}