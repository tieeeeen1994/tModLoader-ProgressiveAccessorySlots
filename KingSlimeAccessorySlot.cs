using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots
{
    public class KingSlimeAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.Instance.enableKingSlimeAccessorySlot && NPC.downedSlimeKing;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
