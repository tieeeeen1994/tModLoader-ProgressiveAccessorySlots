using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.AccessorySlots
{
    public class EverscreamAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.I.enableEverscreamAccessorySlot && NPC.downedChristmasTree;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
