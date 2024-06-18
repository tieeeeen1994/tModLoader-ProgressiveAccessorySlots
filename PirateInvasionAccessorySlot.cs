using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots
{
    public class PirateInvasionAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.Instance.enablePirateInvasionAccessorySlot && NPC.downedPirates;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
