using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots
{
    public class EmpressOfLightAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.Instance.enableEmpressOfLightAccessorySlot && NPC.downedEmpressOfLight;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
