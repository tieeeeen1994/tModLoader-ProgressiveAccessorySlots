using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.AccessorySlots
{
    public class IceQueenAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.I.enableIceQueenAccessorySlot && NPC.downedChristmasIceQueen;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
