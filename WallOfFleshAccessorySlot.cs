using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots
{
    public class WallOfFleshAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.Instance.enableWallOfFleshAccessorySlot && Main.hardMode;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
