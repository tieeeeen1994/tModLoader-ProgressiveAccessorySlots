using Terraria;
using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.AccessorySlots
{
    public class PlanteraAccessorySlot : ModAccessorySlot
    {
        public override bool IsEnabled() => Configuration.I.enablePlanteraAccessorySlot && NPC.downedPlantBoss;

        public override bool IsVisibleWhenNotEnabled() => false;
    }
}
