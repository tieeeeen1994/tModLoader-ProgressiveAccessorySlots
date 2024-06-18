using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots
{
    public class QueenSlimeAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.Instance.enableQueenSlimeAccessorySlot && NPC.downedQueenSlime;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
