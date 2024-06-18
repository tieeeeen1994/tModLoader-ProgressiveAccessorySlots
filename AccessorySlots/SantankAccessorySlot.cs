using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.AccessorySlots
{
    public class SantankAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.I.enableSantaNK1AccessorySlot && NPC.downedChristmasSantank;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
