using static NPCGenerator.Enums.Features;

namespace NPCGenerator.npcs
{
    internal interface IHumanoid : ICharacter
    {
        public HEIGHT HEIGHT { get; }
        public WEIGHT WEIGHT { get; }
        public HAIRCOLOR HAIRCOLOR { get; }
        public HAIRTEXTURE HAIRTEXTURE { get; }
        public SKIN SKIN { get; }
        public WEALTH WEALTH { get; }
    }
}
