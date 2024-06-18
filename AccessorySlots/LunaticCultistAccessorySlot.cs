using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.AccessorySlots
{
    public class LunaticCultistAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.I.enableLunaticCultistAccessorySlot && NPC.downedAncientCultist;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
