using Terraria.GameContent.Events;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.AccessorySlots
{
    public class OldOneArmy2ndAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.I.enableOldOneArmy2ndAccessorySlot && DD2Event.DownedInvasionT2;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
