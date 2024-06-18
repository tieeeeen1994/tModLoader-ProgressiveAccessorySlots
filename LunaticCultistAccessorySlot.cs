using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots
{
    public class LunaticCultistAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.Instance.enableLunaticCultistAccessorySlot && NPC.downedAncientCultist;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
