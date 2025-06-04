using static NPCGenerator.Enums.Traits;

namespace NPCGenerator.Enums
{
    internal class Traits
    {
        public enum SPECIES
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
            NONE,
            FIGHTE,
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
            NONE,
            BAKER,
            SMITH,
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
