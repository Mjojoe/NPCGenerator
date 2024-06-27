using DoorGenerator.Locks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DoorGenerator.Enums;

namespace DoorGenerator.Doors
{
    internal class Paper_Door : Base_Door
    {
        public Paper_Door()
        {
            Locks = new List<Lock>();
            GenerateOpenness();
            GenerateConstruction();
            GenerateLock();
        }
        public override void PrintDoor()
        {
            Console.WriteLine(Construction.ToString() + " Paper Door");
            Console.WriteLine(Openness.ToString());
            Console.WriteLine("With" + Locks.Count + "Locks:");
            foreach (Lock @lock in Locks)
            {
                @lock.PrintLock();
            }
        }
        internal override void GenerateConstruction()
        {
            switch (GetRandomConstruction())
            {
                case CONSTRUCTION.SOLID:
                    Construction = CONSTRUCTION.SOLID; break;
                case CONSTRUCTION.DECREPID:
                    Construction = CONSTRUCTION.DECREPID; break;
                default:
                    GenerateConstruction();
                    break;
            }
        }
    }
}
