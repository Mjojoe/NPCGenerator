namespace DoorGenerator
{
    internal class Enums
    {
        public enum OPENNESS
        {
        OPEN,
        CLOSE,
        LEANED
        }
        public enum MATERIAL
        {
        WOOD,
        STONE,
        METAL,
        GLASS,
        FABRIC,
        PAPER
        };

        public enum CONSTRUCTION
        {
        SOLID,
        DECREPID,
        BARS,
        WINDOWED
        };

        public enum LOCKED
        {
        LOCKED,
        UNLOCKED,
        BARRED,
        };

        public enum LOCKTYPE
        {
        INTEGRATED,
        CHAIN,
        PADLOCK
        };

        public enum BARREDTYPE
        {
        BAR,
        CLUTTER
        }

        public static Array getOpenArray()
        {
            return Enum.GetValues(typeof(OPENNESS));
        }


    }
}
