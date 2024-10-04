using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.Calamity.AccessorySlots
{
    public class Yharon : ModAccessorySlot
    {
        public override bool IsEnabled() => CalamityConfiguration.I.enableYharonAccessorySlot &&
                                            Calamity.CheckDowned("yharon");

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}