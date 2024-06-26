using DoorGenerator;
using System.Diagnostics.CodeAnalysis;
using static DoorGenerator.Enums;
using DoorGenerator.Doors;

namespace DoorGenerator
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
        public static void setOption()
        {
            
        }
        public static void generateOption()
        {
            
        }
        public static void SetOpeness()
        {
            
        }
        public static void SetMaterial()
        {
            
        }

        public static void SetConstruction()
        {
            
        }
        public static void SetLock()
        {
            
        }
        public static void getInput()
        {
            string input = "";
            input = Console.ReadLine().ToLower();
            if (input == "y")
            {
                
            }
            else
            {
               
            }
        }
        public static IDoor GenerateNewDoor()
        {
            Array values = Enum.GetValues(typeof(Enums.MATERIAL));
            Random random = new Random();
            switch ((Enums.MATERIAL)values.GetValue(random.Next(values.Length)))
            {
                case MATERIAL.WOOD:
                    return new Wooden_Door();
                    break;
                case MATERIAL.STONE: 

                    break;
                case MATERIAL.METAL: 
                    break;
                case MATERIAL.GLASS: 
                    break;
                case MATERIAL.FABRIC: 
                    break;
                case MATERIAL.PAPER: 
                    break;
                default:
                    throw new ArgumentException("Beats me what happened ¯\\_(ツ)_/¯");
                    break;
            }
        }
    }
}