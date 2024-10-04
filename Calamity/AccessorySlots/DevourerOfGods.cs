using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.Calamity.AccessorySlots
{
    public class DevourerOfGods : ModAccessorySlot
    {
        public override bool IsEnabled() => CalamityConfiguration.I.enableDevourerOfGodsAccessorySlot &&
                                            Calamity.CheckDowned("devourerofgods");

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}