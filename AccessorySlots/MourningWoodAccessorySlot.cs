using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.AccessorySlots
{
    public class MourningWoodAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.I.enableMourningWoodAccessorySlot && NPC.downedHalloweenKing;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
