using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.AccessorySlots
{
    public class TwinsAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.I.enableTheTwinsAccessorySlot && NPC.downedMechBoss2;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
