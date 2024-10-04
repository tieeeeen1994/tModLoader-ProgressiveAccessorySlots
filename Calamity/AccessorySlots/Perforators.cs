using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.Calamity.AccessorySlots
{
    public class Perforators : ModAccessorySlot
    {
        public override bool IsEnabled() => CalamityConfiguration.I.enablePerforatorAccessorySlot &&
                                            Calamity.CheckDowned("perforators");

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}