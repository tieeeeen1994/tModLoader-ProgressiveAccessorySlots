using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.Calamity.AccessorySlots
{
    public class Cryogen : ModAccessorySlot
    {
        public override bool IsEnabled() => CalamityConfiguration.I.enableCryogenAccessorySlot &&
                                            Calamity.CheckDowned("cryogen");

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}