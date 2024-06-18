using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.AccessorySlots
{
    public class PirateInvasionAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.I.enablePirateInvasionAccessorySlot && NPC.downedPirates;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
