using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.Calamity.AccessorySlots
{
    public class SlimeGod : ModAccessorySlot
    {
        public override bool IsEnabled() => CalamityConfiguration.I.enableSlimeGodAccessorySlot &&
                                            Calamity.CheckDowned("slimegod");

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}