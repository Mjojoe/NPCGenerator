using DoorGenerator.Locks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorGenerator.Doors
{
    internal class Fabric_Door : Base_Door
    {
        public Fabric_Door()
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
        new public void PrintDoor()
        {
            Console.WriteLine(Construction.ToString() + "Fabric Door");
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
