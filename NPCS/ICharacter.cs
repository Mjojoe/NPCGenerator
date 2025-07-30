using static NPCGenerator.Enums.Traits

namespace NPCGenerator.npcs
{
    internal interface ICharacter
    {
        public SPECIES SPIECIES
        public CLASS CLASS { get; }
        public PROFESSION PROFESSION { get; }
        public GOD GOD {  get; }
        public RELIGION RELIGION { get; }
        public void PrintCharacter();
    }
}
