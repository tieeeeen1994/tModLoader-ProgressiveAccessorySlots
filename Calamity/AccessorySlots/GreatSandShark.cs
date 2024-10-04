using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.Calamity.AccessorySlots
{
    public class GreatSandShark : ModAccessorySlot
    {
        public override bool IsEnabled() => CalamityConfiguration.I.enableGreatSandSharkAccessorySlot &&
                                            Calamity.CheckDowned("greatsandshark");

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}