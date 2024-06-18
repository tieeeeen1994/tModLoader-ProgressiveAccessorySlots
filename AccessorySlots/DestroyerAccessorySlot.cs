using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.AccessorySlots
{
    public class DestroyerAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.I.enableTheDestroyerAccessorySlot && NPC.downedMechBoss1;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
