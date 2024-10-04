using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.Calamity.AccessorySlots
{
    public class StormWeaver : ModAccessorySlot
    {
        public override bool IsEnabled() => CalamityConfiguration.I.enableStormWeaverAccessorySlot &&
                                            Calamity.CheckDowned("stormweaver");

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}