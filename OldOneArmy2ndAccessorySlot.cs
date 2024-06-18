using Terraria.GameContent.Events;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots
{
    public class OldOneArmy2ndAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.Instance.enableOldOneArmy2ndAccessorySlot && DD2Event.DownedInvasionT2;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
