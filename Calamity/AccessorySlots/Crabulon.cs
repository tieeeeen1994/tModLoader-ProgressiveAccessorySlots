using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.Calamity.AccessorySlots
{
    public class Crabulon : ModAccessorySlot
    {
        public override bool IsEnabled() => CalamityConfiguration.I.enableCrabulonAccessorySlot &&
                                            Calamity.CheckDowned("crabulon");

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}