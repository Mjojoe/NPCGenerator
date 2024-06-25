// See https://aka.ms/new-console-template for more information

using DoorGenerator;
using static DoorGenerator.Enums;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Door Generator");
        Console.WriteLine("How many doors to generate?");
        int NumofDoors = Convert.ToInt32(Console.ReadLine());
        List<Door> Doors = new List<Door>();

        for (int i = 0; i < NumofDoors; i++)
        {
            Door door = new Door();
            Console.WriteLine("Set state of Openness? [y/n]:");
            MainLoopFunctions.getInput(door, OPENNESS.GetType());



        }
        foreach (Door door in Doors)
        {
            door.printDoor();
        }
    }
}