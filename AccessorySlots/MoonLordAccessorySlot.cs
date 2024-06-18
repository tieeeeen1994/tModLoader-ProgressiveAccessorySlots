using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.AccessorySlots
{
    public class MoonLordAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.I.enableMoonLordAccessorySlot && NPC.downedMoonlord;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
