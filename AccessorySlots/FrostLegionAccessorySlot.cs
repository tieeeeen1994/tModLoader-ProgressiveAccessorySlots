using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.AccessorySlots
{
    public class FrostLegionAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.I.enableFrostLegionAccessorySlot && NPC.downedFrost;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
