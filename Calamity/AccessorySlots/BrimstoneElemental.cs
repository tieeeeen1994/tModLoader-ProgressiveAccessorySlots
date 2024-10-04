using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.Calamity.AccessorySlots
{
    public class BrimstoneElemental : ModAccessorySlot
    {
        public override bool IsEnabled() => CalamityConfiguration.I.enableBrimstoneElementalAccessorySlot &&
                                            Calamity.CheckDowned("brimstoneelemental");

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}