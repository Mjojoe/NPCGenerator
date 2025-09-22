using System.Diagnostics.CodeAnalysis;
using static NPCGenerator.Enums.Traits;
using static NPCGenerator.Enums.Randomizations;
using NPCGenerator.npcs;

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
            switch (GetRandomSpiecies())
            {
                case SPIECIES.HUMAN:
                    return new Humanoid(); 
                case SPIECIES.ELF:
                    return new Humanoid();
                case SPIECIES.DWARF: 
                    return new Humanoid();
                case SPIECIES.HALFELF: 
                    return new Humanoid();
                case SPIECIES.HALFORC: 
                    return new Humanoid();
                default:
                    Console.WriteLine("Beats me what happened ¯\\_(ツ)_/¯");
                    Console.WriteLine("Adding Generic Instance");
                    return new Humanoid();
            }
        }
    }
}