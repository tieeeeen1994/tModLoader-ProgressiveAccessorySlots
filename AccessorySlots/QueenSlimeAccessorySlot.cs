using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.AccessorySlots
{
    public class QueenSlimeAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.I.enableQueenSlimeAccessorySlot && NPC.downedQueenSlime;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
