using Terraria.ModLoader;

namespace ProgressiveAccessorySlots.Calamity
{
    public static class Calamity
    {
        public static Mod Mod => CheckCalamityMod();

        private static Mod CheckCalamityMod()
        {
            if (ModLoader.TryGetMod("CalamityMod", out Mod calamityMod))
            {
                return calamityMod;
            }
            else
            {
                return null;
            }
        }

        public static bool CheckDowned(string name)
        {
            return (bool)Mod?.Call("Downed", name);
        }
    }
}