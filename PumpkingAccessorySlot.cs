using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots
{
    public class PumpkingAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.Instance.enablePumpkingAccessorySlot && NPC.downedHalloweenKing;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
