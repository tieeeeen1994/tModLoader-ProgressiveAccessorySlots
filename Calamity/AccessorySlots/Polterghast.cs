using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.Calamity.AccessorySlots
{
    public class Polterghast : ModAccessorySlot
    {
        public override bool IsEnabled() => CalamityConfiguration.I.enablePolterghastAccessorySlot &&
                                            Calamity.CheckDowned("polterghast");

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}