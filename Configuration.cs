using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace ProgressiveAccessorySlots
{
    public class Configuration : ModConfig
    {
        public static Configuration Instance => ModContent.GetInstance<Configuration>();

        public override ConfigScope Mode => ConfigScope.ServerSide;

        public bool enableKingSlimeAccessorySlot;
        public bool enableEyeOfCthulhuAccessorySlot;
        public bool enableWormOrBrainAccessorySlot;
        public bool enableQueenBeeAccessorySlot;
        public bool enableDeerclopsAccessorySlot;
        public bool enableSkeletronAccessorySlot;
        public bool enableWallOfFleshAccessorySlot;
        public bool enableQueenSlimeAccessorySlot;
        public bool enableTheTwinsAccessorySlot;
        public bool enableTheDestroyerAccessorySlot;
        public bool enableSkeletronPrimeAccessorySlot;
        public bool enablePlanteraAccessorySlot;
        public bool enableEmpressOfLightAccessorySlot;
        public bool enableGolemAccessorySlot;
        public bool enableDukeFishronAccessorySlot;
        public bool enableLunaticCultistAccessorySlot;
        public bool enableMoonLordAccessorySlot;
        public bool enableGoblinArmyAccessorySlot;
        public bool enableFrostLegionAccessorySlot;
        public bool enablePirateInvasionAccessorySlot;
        public bool enableMartianMadnessAccessorySlot;
        public bool enableOldOneArmy1stAccessorySlot;
        public bool enableOldOneArmy2ndAccessorySlot;
        public bool enableOldOneArmy3rdAccessorySlot;
        public bool enableMourningWoodAccessorySlot;
        public bool enablePumpkingAccessorySlot;
        public bool enableEverscreamAccessorySlot;
        public bool enableSantaNK1AccessorySlot;
        public bool enableIceQueenAccessorySlot;

        public Configuration()
        {
            enableKingSlimeAccessorySlot = false;
            enableEyeOfCthulhuAccessorySlot = false;
            enableWormOrBrainAccessorySlot = false;
            enableQueenBeeAccessorySlot = false;
            enableDeerclopsAccessorySlot = false;
            enableSkeletronAccessorySlot = false;
            enableWallOfFleshAccessorySlot = false;
            enableQueenSlimeAccessorySlot = false;
            enableTheTwinsAccessorySlot = false;
            enableTheDestroyerAccessorySlot = false;
            enableSkeletronPrimeAccessorySlot = false;
            enablePlanteraAccessorySlot = false;
            enableEmpressOfLightAccessorySlot = false;
            enableGolemAccessorySlot = false;
            enableDukeFishronAccessorySlot = false;
            enableLunaticCultistAccessorySlot = false;
            enableMoonLordAccessorySlot = false;
            enableGoblinArmyAccessorySlot = false;
            enableFrostLegionAccessorySlot = false;
            enablePirateInvasionAccessorySlot = false;
            enableMartianMadnessAccessorySlot = false;
            enableOldOneArmy1stAccessorySlot = false;
            enableOldOneArmy2ndAccessorySlot = false;
            enableOldOneArmy3rdAccessorySlot = false;
            enableMourningWoodAccessorySlot = false;
            enablePumpkingAccessorySlot = false;
            enableEverscreamAccessorySlot = false;
            enableSantaNK1AccessorySlot = false;
            enableIceQueenAccessorySlot = false;
        }
    }
}
