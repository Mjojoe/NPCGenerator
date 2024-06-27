using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoorGenerator.Locks;
using static DoorGenerator.Enums;

namespace DoorGenerator.Doors
{
    internal class Wooden_Door : Base_Door
    {
        public Wooden_Door()
        {
            Locks = new List<Lock>();
            GenerateOpenness();
            GenerateConstruction();
            Random random = new Random();
            for (int i = 0; i <= random.Next(3); i++)
            {
                GenerateLock();
            }
        }
        public override void PrintDoor()
        {
            Console.WriteLine(Construction.ToString() + " Wooden Door");
            Console.WriteLine(Construction.ToString());
            Console.WriteLine(Openness.ToString());
            Console.WriteLine("With" + Locks.Count + "Locks:");
            foreach (Lock @lock in Locks)
            {
                @lock.PrintLock();
            }
        }
    }
}
