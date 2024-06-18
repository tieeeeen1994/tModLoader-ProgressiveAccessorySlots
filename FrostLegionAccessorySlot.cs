using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots
{
    public class FrostLegionAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.Instance.enableFrostLegionAccessorySlot && NPC.downedFrost;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
