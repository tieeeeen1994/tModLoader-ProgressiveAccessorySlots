using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots
{
    public class PlanteraAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.Instance.enablePlanteraAccessorySlot && NPC.downedPlantBoss;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
