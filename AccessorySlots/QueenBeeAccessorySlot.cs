using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.AccessorySlots
{
    public class QueenBeeAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.I.enableQueenBeeAccessorySlot && NPC.downedQueenBee;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
