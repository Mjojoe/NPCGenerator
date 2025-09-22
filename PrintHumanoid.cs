using NPCGenerator.npcs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NPCGenerator.Enums.Features;
using static NPCGenerator.Enums.Traits;

namespace NPCGenerator
{
    internal class PrintHumanoid
    {
        IHumanoid Humanoid { get; set; }
        public PrintHumanoid(IHumanoid humanoid) 
        {
            Humanoid = humanoid;
        }
        public void PrintCharacter()
        {
            Console.WriteLine(Humanoid.SPIECIES.ToString() + " " + Humanoid.CLASS.ToString());
            Console.WriteLine(Humanoid.HEIGHT.ToString() + " Size");
            Console.WriteLine(Humanoid.WEIGHT.ToString() + " Weight");
            Console.WriteLine(Humanoid.HAIRTEXTURE.ToString() + " " + Humanoid.HAIRCOLOR.ToString() + " Hair");
            Console.WriteLine(Humanoid.SKIN.ToString() + " Skin");
            Console.WriteLine(Humanoid.WEALTH.ToString() + " " + Humanoid.PROFESSION.ToString());

        }
        public string[] WriteCharacterToFile()
        {
            string[] lines = {
                Humanoid.SPIECIES.ToString() + " " + Humanoid.CLASS.ToString(),
                Humanoid.HEIGHT.ToString() + " Size",
                Humanoid.WEIGHT.ToString() + " Weight",
                Humanoid.HAIRTEXTURE.ToString() + " " + Humanoid.HAIRCOLOR.ToString() + " Hair",
                Humanoid.SKIN.ToString() + " Skin",
                Humanoid.WEALTH.ToString() + " " + Humanoid.PROFESSION.ToString(),
            "--------------------------------------------"
            };
            return lines;
        }
    }
}
