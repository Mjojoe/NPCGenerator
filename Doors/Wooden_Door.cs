using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoorGenerator.Locks;
using static DoorGenerator.Enums;

namespace DoorGenerator.Doors
{
    internal class Wooden_Door : IDoor
    {
        public Enums.OPENNESS Openness { get; set; }

        public Enums.CONSTRUCTION Construction { get; set; }

        public List<Lock> Locks { get; set; }
        public Wooden_Door()
        {
            Locks = new List<Lock>();
            GenerateOpennessForWoodenDoor();
            GenerateConstructionForWoodenFoor();
            Random random = new Random();
            for (int i = 0; i <= random.Next(3); i++)
            {
                GenerateLockForWoodenDoor();
            }
        }
        public void PrintDoor()
        {
            Console.WriteLine(Construction.ToString() + "Wooden Door");
            Console.WriteLine(Construction.ToString());
            Console.WriteLine(Openness.ToString());
            Console.WriteLine("With" + Locks.Count + "Locks:");
            foreach (Lock @lock in Locks)
            {
                @lock.PrintLock();
            }
        }
        void GenerateOpennessForWoodenDoor()
        {
            Array values = Enum.GetValues(typeof(OPENNESS));
            Random random = new Random();
            Openness = (Enums.OPENNESS)values.GetValue(random.Next(values.Length));
        }
        void GenerateConstructionForWoodenFoor()
        {
            Array values = Enum.GetValues(typeof(Enums.CONSTRUCTION));
            Random random = new Random();
            Construction = (Enums.CONSTRUCTION)values.GetValue(random.Next(values.Length));
        }
        void AddLockToLocks(Lock @lock)
        {
            if (Locks.Count > 3)
            {
                throw new ArithmeticException("Too many damn Locks!");
            }
            else
            {
                Locks.Add(@lock);
            }
        }
        void GenerateLockForWoodenDoor()
        {
            Array values = Enum.GetValues(typeof(Enums.LOCKTYPE));
            Random random = new Random();
            switch ((Enums.LOCKTYPE)values.GetValue(random.Next(values.Length)))
            {
                case LOCKTYPE.INTEGRATED:
                    AddLockToLocks(new Integrated_Lock()); break;
                case LOCKTYPE.PADLOCK:
                    AddLockToLocks(new Padlock());break;
                case LOCKTYPE.CHAIN:
                    AddLockToLocks(new Chain_Lock()); break;
                case LOCKTYPE.BARRICADE:
                    AddLockToLocks(new Barricade()); break;
                default:
                    throw new ArgumentException("Beats me what happened ¯\\_(ツ)_/¯");
            }
        }
    }
}
