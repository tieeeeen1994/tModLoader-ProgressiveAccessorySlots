using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots
{
    public class EverscreamAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.Instance.enableEverscreamAccessorySlot && NPC.downedChristmasTree;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
