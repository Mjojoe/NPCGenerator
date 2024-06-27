// See https://aka.ms/new-console-template for more information

using DoorGenerator;
using DoorGenerator.Doors;

Console.WriteLine("Door Generator");
Console.WriteLine("How many doors to generate?");
int NumofDoors = Convert.ToInt32(Console.ReadLine());
List<Base_Door> Doors = new();

for (int i = 0; i < NumofDoors; i++)
{
    int doorCount = i + 1;
    Console.WriteLine("Do You want to specify Door #"+ doorCount +"? [y/n]");
    string input = Console.ReadLine().ToLower();

    if (input == "y")
    {
        Console.WriteLine("Lets get Started!");
        Doors.Add(MainLoopFunctions.SetMaterial());
        MainLoopFunctions.SetConstruction(Doors[i]);
        MainLoopFunctions.SetOpeness(Doors[i]);
        Console.WriteLine("How many Locks?");
        int NumOfLocks = Convert.ToInt32(Console.ReadLine());
        if (NumOfLocks > 4) { NumOfLocks = 4; }
        for (int j = 0; j < NumOfLocks; j++)
        {
            MainLoopFunctions.SetLock(Doors[i]);
        }

    }
    else
    {
        Console.WriteLine("Generating random Door ... ");
        Doors.Add(MainLoopFunctions.GenerateNewDoor());
    }
}
Console.WriteLine("These Doors have been created:");
foreach (IDoor door in Doors)
{
    
    Console.WriteLine("----------------------------------------");
    door.PrintDoor();
}

