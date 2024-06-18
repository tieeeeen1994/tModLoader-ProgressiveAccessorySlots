using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.AccessorySlots
{
    public class GoblinArmyAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.I.enableGoblinArmyAccessorySlot && NPC.downedGoblins;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
