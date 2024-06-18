using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.AccessorySlots
{
    public class GolemAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.I.enableGolemAccessorySlot && NPC.downedGolemBoss;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
