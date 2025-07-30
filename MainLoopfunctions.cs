using System.Diagnostics.CodeAnalysis;
using static NPCGenerator.Enums.Traits;
using static NPCGenerator.npcs;

namespace NPCGenerator
{
    static internal class MainLoopFunctions
    {
        public static void PrintEnum(Array @enum)
        {
            foreach (Enum e in @enum)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static Humanoid GenerateCharacter()
        {
            switch (GetRandomMaterial())
            {
                case SPECIES.HUMAN:
                    return new Humanoid(); 
                case SPECIES.ELF:
                    return new Humanoid();
                case SPECIES.DWARF: 
                    return new Humanoid();
                case SPECIES.HALFELF: 
                    return new Humanoid();
                case SPECIES.HALFORC: 
                    return new Humanoid();
                default:
                    Console.WriteLine("Beats me what happened ¯\\_(ツ)_/¯");
                    Console.WriteLine("Adding Generic Instance");
                    return new Humanoid();
            }
        }
    }
}