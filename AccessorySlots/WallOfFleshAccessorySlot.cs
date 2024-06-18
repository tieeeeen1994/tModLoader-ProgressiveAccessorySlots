using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.AccessorySlots
{
    public class WallOfFleshAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.I.enableWallOfFleshAccessorySlot && Main.hardMode;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
