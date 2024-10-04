using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.Calamity.AccessorySlots
{
    public class NuclearTerror : ModAccessorySlot
    {
        public override bool IsEnabled() => CalamityConfiguration.I.enableNuclearTerrorAccessorySlot &&
                                            Calamity.CheckDowned("nuclearterror");

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}