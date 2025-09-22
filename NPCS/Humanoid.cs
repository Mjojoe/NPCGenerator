using static NPCGenerator.Enums.Traits;
using static NPCGenerator.Enums.Features;
using static NPCGenerator.Enums.Randomizations;

namespace NPCGenerator.npcs
{

    internal class Humanoid : IHumanoid
    {
        public SPIECIES SPIECIES { get; private set; }
        public HEIGHT HEIGHT { get; private set; }
        public WEIGHT WEIGHT { get; private set; }
        public HAIRCOLOR HAIRCOLOR { get; private set; }
        public HAIRTEXTURE HAIRTEXTURE { get; private set; }
        public SKIN SKIN { get; private set; }
        public WEALTH WEALTH { get; private set; }
        public CLASS CLASS { get; private set; }
        public PROFESSION PROFESSION { get; private set; }
        public GOD GOD { get; private set; }
        public RELIGION RELIGION { get; private set; }

    public Humanoid()
        {
            SPIECIES = GetRandomSpiecies();
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
            Console.WriteLine("Write a short, paragraph-long story about an NPC.");
            Console.WriteLine("They're a " +
               SPIECIES.ToString() + " " + CLASS.ToString() +
               " of " + HEIGHT.ToString() + ", " + WEIGHT.ToString() + " stature with " +
               HAIRTEXTURE.ToString() + " " + HAIRCOLOR.ToString() + " hair and they live life as a " +
               WEALTH.ToString() + " " + PROFESSION.ToString() + ".");

        }
        public virtual string[] WriteCharacterToFile()
        {
            string[] lines = {
               "Write a short, paragraph-long story about an NPC.",
               "They're a " +
               SPIECIES.ToString() + " " + CLASS.ToString() +
               ", " + HEIGHT.ToString() + "and " + WEIGHT.ToString() + " with " +
               HAIRTEXTURE.ToString() + " " + HAIRCOLOR.ToString() + " hair and they live as a " +  
               WEALTH.ToString() + " " + PROFESSION.ToString() + ".",
               "--------------------------------------------"
            };
            return lines;

            /* 
             * SPIECIES.ToString() + " " + CLASS.ToString(),
                HEIGHT.ToString() + " Size",
                WEIGHT.ToString() + " Weight",
                HAIRTEXTURE.ToString() + " " + HAIRCOLOR.ToString() + " Hair",
                SKIN.ToString() + " Skin",
                WEALTH.ToString() + " " + PROFESSION.ToString(),
            "--------------------------------------------"
             */


        }
    }
}
