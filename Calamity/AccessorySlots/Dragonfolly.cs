using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.Calamity.AccessorySlots
{
    public class Dragonfolly : ModAccessorySlot
    {
        public override bool IsEnabled() => CalamityConfiguration.I.enableDragonfollyAccessorySlot &&
                                            Calamity.CheckDowned("dragonfolly");

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}