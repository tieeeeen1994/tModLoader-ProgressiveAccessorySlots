using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace ProgressiveAccessorySlots.Calamity
{
    public class CalamityConfiguration : ModConfig
    {
        public static CalamityConfiguration I => ModContent.GetInstance<CalamityConfiguration>();

        public override ConfigScope Mode => ConfigScope.ServerSide;

        [Header("Calamity")]
        public bool enableAcidRainOneAccessorySlot;

        public bool enableDesertScourgeAccessorySlot;
        public bool enableGiantClamAccessorySlot;
        public bool enableCrabulonAccessorySlot;
        public bool enableHiveMindAccessorySlot;
        public bool enablePerforatorAccessorySlot;
        public bool enableSlimeGodAccessorySlot;
        public bool enableCryogenAccessorySlot;
        public bool enableHardmodeClamAccessorySlot;
        public bool enableAcidRainTwoAccessorySlot;
        public bool enableAquaticScourgeAccessorySlot;
        public bool enableCragmawMireAccessorySlot;
        public bool enableBrimstoneElementalAccessorySlot;
        public bool enableCalamitasCloneAccessorySlot;
        public bool enableGreatSandSharkAccessorySlot;
        public bool enableLeviathanAccessorySlot;
        public bool enableAstrumAureusAccessorySlot;
        public bool enablePlaguebringerGoliathAccessorySlot;
        public bool enableRavagerAccessorySlot;
        public bool enableAstrumDeusAccessorySlot;
        public bool enableProfanedGuardianAccessorySlot;
        public bool enableDragonfollyAccessorySlot;
        public bool enableProvidenceAccessorySlot;
        public bool enablePolterghastAccessorySlot;
        public bool enableMaulerAccessorySlot;
        public bool enableNuclearTerrorAccessorySlot;
        public bool enableAcidRainThreeAccessorySlot;
        public bool enableCeaselessVoidAccessorySlot;
        public bool enableStormWeaverAccessorySlot;
        public bool enableSignusAccessorySlot;
        public bool enableDevourerOfGodsAccessorySlot;
        public bool enableYharonAccessorySlot;
        public bool enableExoMechsAccessorySlot;
        public bool enableSupremeCalamitasAccessorySlot;
        public bool enableEidolonWyrmAccessorySlot;
        public bool enableBossRushAccessorySlot;

        public CalamityConfiguration()
        {
            enableAcidRainOneAccessorySlot = false;
            enableDesertScourgeAccessorySlot = false;
            enableGiantClamAccessorySlot = false;
            enableCrabulonAccessorySlot = false;
            enableHiveMindAccessorySlot = false;
            enablePerforatorAccessorySlot = false;
            enableSlimeGodAccessorySlot = false;
            enableCryogenAccessorySlot = false;
            enableHardmodeClamAccessorySlot = false;
            enableAcidRainTwoAccessorySlot = false;
            enableAquaticScourgeAccessorySlot = false;
            enableCragmawMireAccessorySlot = false;
            enableBrimstoneElementalAccessorySlot = false;
            enableCalamitasCloneAccessorySlot = false;
            enableGreatSandSharkAccessorySlot = false;
            enableLeviathanAccessorySlot = false;
            enableAstrumAureusAccessorySlot = false;
            enablePlaguebringerGoliathAccessorySlot = false;
            enableRavagerAccessorySlot = false;
            enableAstrumDeusAccessorySlot = false;
            enableProfanedGuardianAccessorySlot = false;
            enableDragonfollyAccessorySlot = false;
            enableProvidenceAccessorySlot = false;
            enablePolterghastAccessorySlot = false;
            enableMaulerAccessorySlot = false;
            enableNuclearTerrorAccessorySlot = false;
            enableAcidRainThreeAccessorySlot = false;
            enableCeaselessVoidAccessorySlot = false;
            enableStormWeaverAccessorySlot = false;
            enableSignusAccessorySlot = false;
            enableDevourerOfGodsAccessorySlot = false;
            enableYharonAccessorySlot = false;
            enableExoMechsAccessorySlot = false;
            enableSupremeCalamitasAccessorySlot = false;
            enableEidolonWyrmAccessorySlot = false;
            enableBossRushAccessorySlot = false;
        }
    }
}