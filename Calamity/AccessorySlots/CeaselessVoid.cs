using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.Calamity.AccessorySlots
{
    public class CeaselessVoid : ModAccessorySlot
    {
        public override bool IsEnabled() => CalamityConfiguration.I.enableCeaselessVoidAccessorySlot &&
                                            Calamity.CheckDowned("ceaselessvoid");

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}