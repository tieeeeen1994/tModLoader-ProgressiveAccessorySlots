using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.Calamity.AccessorySlots
{
    public class EidolonWyrm : ModAccessorySlot
    {
        public override bool IsEnabled() => CalamityConfiguration.I.enableEidolonWyrmAccessorySlot &&
                                            Calamity.CheckDowned("adulteidolonwyrm");

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}