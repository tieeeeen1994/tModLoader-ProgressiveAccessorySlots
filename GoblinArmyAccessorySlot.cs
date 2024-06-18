using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots
{
    public class GoblinArmyAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.Instance.enableGoblinArmyAccessorySlot && NPC.downedGoblins;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
