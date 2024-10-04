using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.Calamity.AccessorySlots
{
    public class Leviathan : ModAccessorySlot
    {
        public override bool IsEnabled() => CalamityConfiguration.I.enableLeviathanAccessorySlot &&
                                            Calamity.CheckDowned("leviathan");

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}