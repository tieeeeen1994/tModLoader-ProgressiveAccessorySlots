using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.AccessorySlots
{
    public class DeerclopsAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.I.enableDeerclopsAccessorySlot && NPC.downedDeerclops;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
