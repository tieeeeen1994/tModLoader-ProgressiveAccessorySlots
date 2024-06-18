using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.AccessorySlots
{
    public class PumpkingAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.I.enablePumpkingAccessorySlot && NPC.downedHalloweenKing;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
