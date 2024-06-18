using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots
{
    public class QueenBeeAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.Instance.enableQueenBeeAccessorySlot && NPC.downedQueenBee;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
