using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots
{
    public class SkeletronAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.Instance.enableSkeletronAccessorySlot && NPC.downedBoss3;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
