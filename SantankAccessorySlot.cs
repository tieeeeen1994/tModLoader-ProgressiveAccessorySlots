using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots
{
    public class SantankAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.Instance.enableSantaNK1AccessorySlot && NPC.downedChristmasSantank;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
