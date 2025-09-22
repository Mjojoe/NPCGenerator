using static NPCGenerator.Enums.Traits;

namespace NPCGenerator.npcs
{
    internal interface ICharacter
    {
        public SPIECIES SPIECIES { get; }
        public CLASS CLASS { get; }
        public PROFESSION PROFESSION { get; }
        public GOD GOD {  get; }
        public RELIGION RELIGION { get; }
        public void PrintCharacter();
        public string [] WriteCharacterToFile();
    }
}
