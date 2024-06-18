using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.AccessorySlots
{
    public class Boss2AccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.I.enableWormOrBrainAccessorySlot && NPC.downedBoss2;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
