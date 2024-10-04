using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.Calamity.AccessorySlots
{
    public class ExoMechs : ModAccessorySlot
    {
        public override bool IsEnabled() => CalamityConfiguration.I.enableExoMechsAccessorySlot &&
                                            Calamity.CheckDowned("exomechs");

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}