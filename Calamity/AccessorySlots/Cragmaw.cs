using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.Calamity.AccessorySlots
{
    public class Cragmaw : ModAccessorySlot
    {
        public override bool IsEnabled() => CalamityConfiguration.I.enableCragmawMireAccessorySlot &&
                                            Calamity.CheckDowned("cragmawmire");

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}