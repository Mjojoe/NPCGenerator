using static NPCGenerator.Enums.Traits;

namespace NPCGenerator.Enums
{
    internal class Features

    {
        public enum HEIGHT
        {
           TALL,
           SHORT,
           AVARAGE

        }
        public enum WEIGHT
        {
            VERY_HEAVY,
            HEAVY,
            AVARAGE,
            HEALTHY,
            SKINNY,
            VERY_SKINNY
        };
        public enum HAIRCOLOR
        {
            WHITE,
            BLONDE,
            DARKBLONDE,
            BORWN,
            DARKBROWN,
            BLACK,
            EBONY,
            RED
        };
        public enum HAIRTEXTURE
        {
            THICK,
            THIN,
            LONG,
            SHORT,
            CURLY,
            NONE,
        };
        public enum SKIN
        {
            TYPICAL,
            UNUSUAL,
            TANNED,
            PALE,
            WEATHERED,
            ROUGH,
            SMOOTH,
        }
        public enum HORNS
        {
            STRAIGHT,
            CURVED,
            BROKEN,
            MISMATCHED,
            REINFORCED
        }
        public enum TEETH
        {
            REGULAR,
            BIG_LOWER_CANINES,
            BIG_UPPER_CANINES,
            BROKEN_CANINIES,
        }
        public enum WEALTH
        {
            RICH,
            POOR,
            LOADED,
            REGULAR,
            DESTITUTE
        }
    }
}
