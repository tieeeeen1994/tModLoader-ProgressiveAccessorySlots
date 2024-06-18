using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.AccessorySlots
{
    public class KingSlimeAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.I.enableKingSlimeAccessorySlot && NPC.downedSlimeKing;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
