using DoorGenerator;
using System.Diagnostics.CodeAnalysis;
using static DoorGenerator.Enums;

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
        public static void setOption(string option, Door door, Type @enum)
        {
            switch(@enum)
            {
                case OPENNESS;: 
                    SetOpeness(option, door); break;
                case MATERIAL:
                    break;
                case CONSTRUCTION: 
                    break;
                case LOCKED:
                    Console.WriteLine("How many Locks?");
                    int NumOfLocks = Convert.ToInt32(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Cannot identify Enum Type to set.");
                    break;
            }
        }
        public static void generateOption(Door door, Enum @enum)
        {
            switch (@enum)
            {
                case Enums.OPENNESS:
                    door.generateOpeness(); break;
                case Enums.MATERIAL:
                    door.generateMaterial(); break;
                case Enums.CONSTRUCTION:
                    door.generateConstruction(); break;
                case Enums.LOCKED:
                    door.GenerateLocks(); break;
            }
        }
        public static void SetOpeness(string selection, Door door)
        {
            switch (selection.ToLower())
            {
                case "open":
                    door.Openess = Enums.OPENNESS.OPEN; break;
                case "leaned":
                    door.Openess = Enums.OPENNESS.LEANED; break;
                case "closed":
                    door.Openess = Enums.OPENNESS.CLOSE; break;
                default:
                    Console.WriteLine("Cannot parse. Generating random");
                    door.generateOpeness();
                    break;
            }
        }
        public static void SetMaterial(string selection, Door door)
        {
            switch (selection.ToLower())
            {
                case "wood":
                    door.Material = Enums.MATERIAL.WOOD; break;
                case "stone":
                    door.Material = Enums.MATERIAL.STONE; break;
                case "metal":
                    door.Material = Enums.MATERIAL.METAL; break;
                case "glass":
                    door.Material = Enums.MATERIAL.GLASS; break;
                case "fabric":
                    door.Material = Enums.MATERIAL.FABRIC; break;
                case "Paper":
                    door.Material = Enums.MATERIAL.PAPER; break;
                default:
                    Console.WriteLine("Cannot parse. Generating random");
                    door.generateMaterial();
                    break;
            }
        }

        public static void SetConstruction(string selection, Door door)
        {
            switch (selection.ToLower())
            {
                case "solid":
                    door.Construction = Enums.CONSTRUCTION.SOLID; break;
                case "decrepid":
                    door.Construction = Enums.CONSTRUCTION.DECREPID; break;
                case "bars" when door.Material != MATERIAL.FABRIC:
                    if(door.Material != MATERIAL.GLASS)
                    {
                        door.Construction = Enums.CONSTRUCTION.BARS; break;
                    }
                    else
                    {
                        Console.WriteLine("Fabric and Glass Doors cannot be made from bars!");
                    }
                    break;
                    
                case "windowed" when door.Material != MATERIAL.GLASS:
                    if(door.Material == MATERIAL.FABRIC)
                    {
                        door.Construction = Enums.CONSTRUCTION.WINDOWED; break;
                    }
                    else
                    {
                        Console.WriteLine("Fabric and Glass doors cannot have windows!");
                    }
                    break;
                default:
                    Console.WriteLine("Cannot parse. Generating random");
                    door.generateConstruction(); 
                    break;
            }
        }
        public static void SetLock(string selection, Door door)
        {
            switch (selection.ToLower())
            {
                case "locked" when door.Material != MATERIAL.FABRIC:
                    door.Material = Enums.MATERIAL.WOOD; break;
                case "unlocked":
                    door.Material = Enums.MATERIAL.STONE; break;
                case "barred" when door.Material != MATERIAL.FABRIC:
                    door.Material = Enums.MATERIAL.METAL; break;
                default:
                    Console.WriteLine("Cannot parse. Generating random");
                    door.generateMaterial();
                    break;
            }
        }
        public static void getInput(Door door, Type @enum)
        {
            string input = "";
            input = Console.ReadLine().ToLower();
            if (input == "y")
            {
                string option;
                PrintEnum(Enum.GetValues(@enum.GetType()));
                option = Console.ReadLine();
                setOption(option, door, @enum);
            }
            else
            {
                generateOption(door, @enum);
            }
        }
    }
}