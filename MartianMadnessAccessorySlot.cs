using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots
{
    public class MartianMadnessAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.Instance.enableMartianMadnessAccessorySlot && NPC.downedMartians;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
