using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.Calamity.AccessorySlots
{
    public class Ravager : ModAccessorySlot
    {
        public override bool IsEnabled() => CalamityConfiguration.I.enableRavagerAccessorySlot &&
                                            Calamity.CheckDowned("ravager");

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}