using static NPCGenerator.Enums.Traits;

namespace NPCGenerator.Enums
{
    internal class Traits
    {
        public enum SPIECIES
        {
           HUMAN,
           ELF,
           DWARF,
           ORC,
           HALFELF,
           HALFDWARF,
           HALFORC,

        }
        public enum CLASS
        {
            PEASANT,
            FIGHTER,
            ROGUE,
            WIZARD,
            SORCERER,
            WARLOCK,
            DRUID,
            CLERIC,
            PALADIN,
            RANGER,
            MONK,
            BARD,
        };
        public enum PROFESSION
        {
            WAYFARER,
            BAKER,
            BLACKSMITH,
            GOLDSMITH,
            SHOPKEEPER,
            FARMER,
            TRADER,
            APOTHECARY,
            WORKER,
            PRIEST,
            ADVENTURER
        };
        public enum GOD
        {
            NONE,
        };
        public enum RELIGION
        {
            NONE, 
        }
        public enum SEX
        {
            MALE,
            FEMALE,
        }
        public enum GENDER
        {
            NONE,
            MALE,
            FEMALE
        }
    }
}
