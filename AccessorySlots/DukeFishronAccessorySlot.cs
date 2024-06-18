using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.AccessorySlots
{
    public class DukeFishronAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.I.enableDukeFishronAccessorySlot && NPC.downedFishron;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
