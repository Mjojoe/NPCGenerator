using static NPCGenerator.Enums.Features;
using static NPCGenerator.Enums.Traits;

namespace NPCGenerator.Enums
{
    internal class Randomizations
    {
        public static SPECIES GetRandomSpecies()
        {
            Array values = Enum.GetValues(typeof(SPECIES));
            Random random = new Random();
            return (SPECIES)values.GetValue(random.Next(values.Length));
        }
        public static CLASS GetRandomClass()
        {
            Array values = Enum.GetValues(typeof(CLASS));
            Random random = new Random();
            return (CLASS)values.GetValue(random.Next(values.Length));
        }
        public static PROFESSION GetRandomProfession()
        {
            Array values = Enum.GetValues(typeof(PROFESSION));
            Random random = new Random();
            return (PROFESSION)values.GetValue(random.Next(values.Length));
        }
        public static SEX GetRandomSex()
        {
            Array values = Enum.GetValues(typeof(SEX));
            Random random = new Random();
            return (SEX)values.GetValue(random.Next(values.Length));
        }
        public static GENDER GetRandomGender()
        {
            Array values = Enum.GetValues(typeof(GENDER));
            Random random = new Random();
            return (GENDER)values.GetValue(random.Next(values.Length));
        }
        public static GOD GetRandomGod()
        {
            return GOD.NONE;
        }
        public static RELIGION GetRandomReligion()
        {
            return RELIGION.NONE;
        }
        public static HEIGHT GetRandomHeight()
        {
            Array values = Enum.GetValues(typeof(HEIGHT));
            Random random = new Random();
            return (HEIGHT)values.GetValue(random.Next(values.Length));
        }
        public static WEIGHT GetRandomWeight()
        {
            Array values = Enum.GetValues(typeof(WEIGHT));
            Random random = new Random();
            return (WEIGHT)values.GetValue(random.Next(values.Length));
        }
        public static HAIRCOLOR GetRandomHaircolor()
        {
            Array values = Enum.GetValues(typeof(HAIRCOLOR));
            Random random = new Random();
            return (HAIRCOLOR)values.GetValue(random.Next(values.Length));
        }
        public static HAIRTEXTURE GetRandomHairtexture()
        {
            Array values = Enum.GetValues(typeof(HAIRTEXTURE));
            Random random = new Random();
            return (HAIRTEXTURE)values.GetValue(random.Next(values.Length));
        }
        public static SKIN GetRandomSkin()
        {
            Array values = Enum.GetValues(typeof(SKIN));
            Random random = new Random();
            return (SKIN)values.GetValue(random.Next(values.Length));
        }
        public static HORNS GetRandomHorns()
        {
            Array values = Enum.GetValues(typeof(HORNS));
            Random random = new Random();
            return (HORNS)values.GetValue(random.Next(values.Length));
        }
        public static TEETH GetRandomTeeth()
        {
            Array values = Enum.GetValues(typeof(TEETH));
            Random random = new Random();
            return (TEETH)values.GetValue(random.Next(values.Length));
        }
        public static WEALTH GetRandomWealth()
        {
            Array values = Enum.GetValues(typeof(WEALTH));
            Random random = new Random();
            return (WEALTH)values.GetValue(random.Next(values.Length));
        }
    }
}
