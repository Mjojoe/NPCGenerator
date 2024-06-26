// See https://aka.ms/new-console-template for more information

using DoorGenerator;
using static DoorGenerator.Enums;
using DoorGenerator.Doors;
using DoorGenerator.Locks;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Door Generator");
        Console.WriteLine("How many doors to generate?");
        int NumofDoors = Convert.ToInt32(Console.ReadLine());
        List<IDoor> Doors = new List<IDoor>();

        for (int i = 0; i < NumofDoors; i++)
        {

            if(false)
            {

            }
            else
            {

            }



        }
        foreach (IDoor door in Doors)
        {
            Console.WriteLine("These Doors have been created:");
            door.PrintDoor();
            Console.WriteLine("----------------------------------------");
        }
    }
}