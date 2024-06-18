using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots
{
    public class MoonLordAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.Instance.enableMoonLordAccessorySlot && NPC.downedMoonlord;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
