using Terraria.GameContent.Events;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.AccessorySlots
{
    public class OldOneArmy3rdAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.I.enableOldOneArmy3rdAccessorySlot && DD2Event.DownedInvasionT3;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
