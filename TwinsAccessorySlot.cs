using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots
{
    public class TwinsAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.Instance.enableTheTwinsAccessorySlot && NPC.downedMechBoss2;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
