using static DoorGenerator.Enums;

namespace DoorGenerator
{
    internal class Enums
    {
        public enum OPENNESS
        {
        OPEN,
        CLOSE,
        HALFOPEN
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
        LATTICED,
        WINDOWED
        };
        public enum LOCKTYPE
        {
        INTEGRATED,
        CHAIN,
        PADLOCK,
        BARRICADE
        };
        public enum BARRICADETYPE
        {
        PLANK,
        CLUTTER
        }

        public static OPENNESS GetRandomOpenness()
        {
            Array values = Enum.GetValues(typeof(OPENNESS));
            Random random = new Random();
            return (OPENNESS)values.GetValue(random.Next(values.Length));
        }
        public static MATERIAL GetRandomMaterial()
        {
            Array values = Enum.GetValues(typeof(MATERIAL));
            Random random = new Random();
            return (MATERIAL)values.GetValue(random.Next(values.Length));
        }
        public static CONSTRUCTION GetRandomConstruction()
        {
            Array values = Enum.GetValues(typeof(CONSTRUCTION));
            Random random = new Random();
            return (CONSTRUCTION)values.GetValue(random.Next(values.Length));
        }
        public static LOCKTYPE GetRandomLocktype()
        {
            Array values = Enum.GetValues(typeof(LOCKTYPE));
            Random random = new Random();
            return (LOCKTYPE)values.GetValue(random.Next(values.Length));
        }
        public static BARRICADETYPE GetRandomBarricadeType()
        {
            Array values = Enum.GetValues(typeof(BARRICADETYPE));
            Random random = new Random();
            return (BARRICADETYPE)values.GetValue(random.Next(values.Length));
        }
    }
}
