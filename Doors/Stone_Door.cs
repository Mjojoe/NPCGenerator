using DoorGenerator.Locks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DoorGenerator.Enums;

namespace DoorGenerator.Doors
{
    internal class Stone_Door : Base_Door
    {
        public Stone_Door()
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
            Console.WriteLine(Construction.ToString() + " Stone Door");
            Console.WriteLine(Construction.ToString());
            Console.WriteLine(Openness.ToString());
            Console.WriteLine("With" + Locks.Count + "Locks:");
            foreach (Lock @lock in Locks)
            {
                @lock.PrintLock();
            }
        }
        internal override void GenerateConstruction()
        {
            Construction = GetRandomConstruction();
            if(Construction == CONSTRUCTION.LATTICED) { Construction = CONSTRUCTION.SOLID; }
        }
    }
}
