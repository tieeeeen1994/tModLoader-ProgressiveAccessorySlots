using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.AccessorySlots
{
    public class EyeOfCthulhuAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.I.enableEyeOfCthulhuAccessorySlot && NPC.downedBoss1;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
