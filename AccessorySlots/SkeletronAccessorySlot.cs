using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.AccessorySlots
{
    public class SkeletronAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.I.enableSkeletronAccessorySlot && NPC.downedBoss3;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
