using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.Calamity.AccessorySlots
{
    public class GiantClam : ModAccessorySlot
    {
        public override bool IsEnabled() => CalamityConfiguration.I.enableGiantClamAccessorySlot &&
                                            Calamity.CheckDowned("giantclam");

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}