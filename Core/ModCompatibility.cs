namespace SOR.Core
{
    public static class ModCompatibility
    {
        public static class Fargowiltas
        {
            public const string Name = "Fargowiltas";
            public static Mod Mod => ModLoader.GetMod(Name);
        }
        public static class FargoSeeds
        {
            public const string Name = "FargoSeeds";
            public static Mod Mod => ModLoader.GetMod(Name);
        }
        public static class FargowiltasSouls
        {
            public const string Name = "FargowiltasSouls";
            public static Mod Mod => ModLoader.GetMod(Name);
        }
        public static class Luminance
        {
            public const string Name = "Luminance";
            public static Mod Mod => ModLoader.GetMod(Name);
        }
        public static class Daybreak
        {
            public const string Name = "Daybreak";
            public static bool Loaded => ModLoader.HasMod(Name);
            public static Mod Mod => ModLoader.GetMod(Name);
        }
        public static class SpiritMod
        {
            public const string Name = "SpiritMod";
            public static bool Loaded => ModLoader.HasMod(Name);
            public static Mod Mod => ModLoader.GetMod(Name);
        }
        public static class SpiritReforged
        {
            public const string Name = "SpiritReforged";
            public static bool Loaded => ModLoader.HasMod(Name);
            public static Mod Mod => ModLoader.GetMod(Name);
        }
    }
}