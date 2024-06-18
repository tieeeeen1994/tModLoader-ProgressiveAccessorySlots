using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots
{
    public class DeerclopsAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.Instance.enableDeerclopsAccessorySlot && NPC.downedDeerclops;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
