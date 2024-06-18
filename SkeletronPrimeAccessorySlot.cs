using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots
{
    public class SkeletronPrimeAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.Instance.enableSkeletronPrimeAccessorySlot && NPC.downedMechBoss3;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
