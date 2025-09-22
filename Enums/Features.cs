using static NPCGenerator.Enums.Traits;

namespace NPCGenerator.Enums
{
    internal class Features

    {
        public enum HEIGHT
        {
           TALL,
           SHORT,
           AVERAGE_HEIGHT

        }
        public enum WEIGHT
        {
            VERY_HEAVY,
            OF_HEAVY_WEIGHT,
            OF_AVARAGE_WEIGHT,
            OF_HEALTHY_WEIGHT,
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
            BALD,
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
            WEALTHY,
            POOR,
            ARISTOCRATIC,
            MODEST,
            DESTITUTE
        }
    }
}
