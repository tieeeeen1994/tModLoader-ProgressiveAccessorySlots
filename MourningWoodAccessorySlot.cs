using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots
{
    public class MourningWoodAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.Instance.enableMourningWoodAccessorySlot && NPC.downedHalloweenKing;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
