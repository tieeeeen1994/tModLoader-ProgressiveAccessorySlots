using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots
{
    public class DestroyerAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.Instance.enableTheDestroyerAccessorySlot && NPC.downedMechBoss1;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
