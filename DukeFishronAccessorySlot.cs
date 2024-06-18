using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots
{
    public class DukeFishronAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.Instance.enableDukeFishronAccessorySlot && NPC.downedFishron;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
