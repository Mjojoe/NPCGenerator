using static NPCGenerator.Enums.Traits;
using static NPCGenerator.Enums.Features;
using static NPCGenerator.Enums.Randomizations;



namespace DoorGenerator.npcs
{
    internal class Humanoid : IHumanoid
    {
        public SPECIES SPECIES { get; private set; }
        public HEIGHT HEIGHT { get; private set; }
        public WEIGHT WEIGHT { get; private set; }
        public HAIRCOLOR HAIRCOLOR { get; private set; }
        public HAIRTEXTURE HAIRTEXTURE { get; private set; }
        public SKIN SKIN { get; private set; }
        public WEALTH WEALTH { get; private set; }
        public CLASS CLASS { get; private set; }
        public PROFESSION PROFESSION { get; private set; }

        public Humanoid() {
            SPECIES = GetRandomSpecies();
            HEIGHT = GetRandomHeight();
            WEIGHT = GetRandomWeight();
            HAIRCOLOR = GetRandomHaircolor();
            HAIRTEXTURE = GetRandomHairtexture();
            SKIN = GetRandomSkin();
            WEALTH = GetRandomWealth();
            CLASS = GetRandomClass();
            PROFESSION = GetRandomProfession();
        }

        public virtual void PrintCharacter()
        {
            Console.WriteLine(SPECIES.ToString());
            Console.WriteLine(HEIGHT.ToString());
            Console.WriteLine(WEIGHT.ToString());
            Console.WriteLine(HAIRCOLOR.ToString());
            Console.WriteLine(HAIRTEXTURE.ToString());
            Console.WriteLine(SKIN.ToString());
            Console.WriteLine(WEALTH.ToString());
            Console.WriteLine(CLASS.ToString());
            Console.WriteLine(PROFESSION.ToString();
            
        }
    }
}
