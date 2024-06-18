using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.AccessorySlots
{
    public class MartianMadnessAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.I.enableMartianMadnessAccessorySlot && NPC.downedMartians;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
