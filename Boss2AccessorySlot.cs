using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots
{
    public class Boss2AccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.Instance.enableWormOrBrainAccessorySlot && NPC.downedBoss2;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
