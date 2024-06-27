using DoorGenerator;
using System.Diagnostics.CodeAnalysis;
using static DoorGenerator.Enums;
using DoorGenerator.Doors;
using DoorGenerator.Locks;

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
        public static Base_Door SetMaterial()
        {
            Console.WriteLine("Select Material or skip:");
            PrintEnum(Enum.GetValues(typeof(MATERIAL)));
            switch(Console.ReadLine().ToLower()) 
            {
                case "wood":
                    return new Wooden_Door();
                case "stone":
                    return new Stone_Door();
                case "metal":
                    return new Metal_Door();
                case "glass":
                    return new Glass_Door();
                case "fabric":
                    return new Fabric_Door();
                case "paper":
                    return new Paper_Door();
                default:
                    Console.WriteLine("Adding Random Door");
                    return GenerateNewDoor();
            }
        }
        public static void SetConstruction(Base_Door door)
        {
            Console.WriteLine("Select Construction or skip:");
            PrintEnum(Enum.GetValues(typeof(CONSTRUCTION)));
            switch (Console.ReadLine().ToLower())
            {
                case "solid" :
                    door.Construction = CONSTRUCTION.SOLID; break;
                case "decrepid":
                    door.Construction = CONSTRUCTION.DECREPID; break;
                case "latticed":
                    door.Construction = CONSTRUCTION.LATTICED; break;
                case "windowed":
                    door.Construction = CONSTRUCTION.WINDOWED; break;
                default:
                    Console.WriteLine("Selecting at random");
                    door.GenerateConstruction();
                    break;
            }
        }
        public static void SetOpeness(Base_Door door)
        {
            Console.WriteLine("Select Openness or skip:");
            PrintEnum(Enum.GetValues(typeof(OPENNESS)));
            switch (Console.ReadLine().ToLower())
            {
                case "open":
                    door.Openness = OPENNESS.OPEN; break;
                case "closed":
                    door.Openness = OPENNESS.CLOSE; break;
                case "halfopen":
                    door.Openness = OPENNESS.HALFOPEN; break;
                default:
                    Console.WriteLine("Selecting at random");
                    door.GenerateConstruction();
                    break;
            }
        }
        public static void SetLock(Base_Door door)
        {
            Console.WriteLine("Select Locktype or skip:");
            PrintEnum(Enum.GetValues(typeof(LOCKTYPE)));
            switch (Console.ReadLine().ToLower())
            {
                case "integrated":
                    door.AddLockToLocks(new Integrated_Lock(SetLocked())); break;
                case "chain":
                    door.AddLockToLocks(new Chain_Lock(SetLocked())); break;
                case "padlock":
                    door.AddLockToLocks(new Padlock(SetLocked())); break;
                case "barricade":
                    door.AddLockToLocks(new Barricade(SetBarricadeType(), SetLocked())); break;
                default:
                    Console.WriteLine("Selecting at random");
                    door.GenerateConstruction();
                    break;
            }
        }
        public static bool SetLocked()
        {
            Console.WriteLine("Locked or Unlocked or skip?");
            switch (Console.ReadLine().ToLower())
            {
                case "locked":
                    return true;
                case "unlocked":
                    return false;
                default:
                    Console.WriteLine("Locking Door!");
                    return true;
            }

        }
        public static BARRICADETYPE SetBarricadeType()
        {
            Console.WriteLine("Select Barricadetype or skip:");
            PrintEnum(Enum.GetValues(typeof(BARRICADETYPE)));
            switch (Console.ReadLine().ToLower())
            {
                case "plank":
                    return BARRICADETYPE.PLANK;
                case "clutter":
                    return BARRICADETYPE.CLUTTER;
                default: 
                    Console.WriteLine("Selecting Random");
                    return GetRandomBarricadeType();
            }
        }
        public static void getInput()
        {
            string input = Console.ReadLine().ToLower();
            if (input == "y")
            {
                
            }
            else
            {
               
            }
        }
        public static Base_Door GenerateNewDoor()
        {
            switch (GetRandomMaterial())
            {
                case MATERIAL.WOOD:
                    return new Wooden_Door();
                case MATERIAL.STONE: 
                    return new Stone_Door();
                case MATERIAL.METAL: 
                    return new Metal_Door();
                case MATERIAL.GLASS: 
                    return new Glass_Door();
                case MATERIAL.FABRIC: 
                    return new Fabric_Door();
                case MATERIAL.PAPER: 
                    return new Paper_Door();
                default:
                    Console.WriteLine("Beats me what happened ¯\\_(ツ)_/¯");
                    Console.WriteLine("Adding Generic Door");
                    return new Base_Door();
            }
        }
    }
}