using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.AccessorySlots
{
    public class TorchGodAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.I.enableTorchGodAccessorySlot && Player.unlockedBiomeTorches;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
