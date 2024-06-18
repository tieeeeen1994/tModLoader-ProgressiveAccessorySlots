using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots
{
    public class GolemAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.Instance.enableGolemAccessorySlot && NPC.downedGolemBoss;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
