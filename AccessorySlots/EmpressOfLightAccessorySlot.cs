using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.AccessorySlots
{
    public class EmpressOfLightAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.I.enableEmpressOfLightAccessorySlot && NPC.downedEmpressOfLight;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
