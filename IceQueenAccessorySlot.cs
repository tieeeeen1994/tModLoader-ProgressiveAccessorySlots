using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots
{
    public class IceQueenAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.Instance.enableIceQueenAccessorySlot && NPC.downedChristmasIceQueen;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
