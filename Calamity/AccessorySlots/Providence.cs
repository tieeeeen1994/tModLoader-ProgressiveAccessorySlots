using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.Calamity.AccessorySlots
{
    public class Providence : ModAccessorySlot
    {
        public override bool IsEnabled() => CalamityConfiguration.I.enableProvidenceAccessorySlot &&
                                            Calamity.CheckDowned("providence");

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}