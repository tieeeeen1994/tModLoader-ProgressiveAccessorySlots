using Terraria.GameContent.Events;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.AccessorySlots
{
    public class OldOneArmy1stAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.I.enableOldOneArmy1stAccessorySlot && DD2Event.DownedInvasionT1;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
