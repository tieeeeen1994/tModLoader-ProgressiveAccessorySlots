using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.AccessorySlots
{
    public class SkeletronPrimeAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.I.enableSkeletronPrimeAccessorySlot && NPC.downedMechBoss3;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
