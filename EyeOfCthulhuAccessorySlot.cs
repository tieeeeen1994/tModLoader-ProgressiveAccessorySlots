using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots
{
    public class EyeOfCthulhuAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.Instance.enableEyeOfCthulhuAccessorySlot && NPC.downedBoss1;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
