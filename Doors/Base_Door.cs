using DoorGenerator.Locks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DoorGenerator.Enums;

namespace DoorGenerator.Doors
{
    internal class Base_Door : IDoor
    {
        public Enums.OPENNESS Openness { get; set; }

        public Enums.CONSTRUCTION Construction { get; set; }

        public List<Lock> Locks { get; set; }
        public  Base_Door()
        {
            Locks = new List<Lock>();
            GenerateOpenness();
            GenerateConstruction();
            GenerateLock();
        }
        public virtual void PrintDoor() 
        {
            Console.WriteLine(Construction.ToString() + " Door");
            Console.WriteLine(Openness.ToString());
            Console.WriteLine("With " + Locks.Count + " Locks:");
            foreach (Lock @lock in Locks)
            {
                @lock.PrintLock();
            }
        }
        internal virtual void GenerateOpenness()
        {
            Openness = GetRandomOpenness();
        }
        internal virtual void GenerateConstruction()
        {
            Construction = GetRandomConstruction();
        }
        internal virtual void AddLockToLocks(Lock @lock)
        {
            if (Locks.Count >= 3)
            {
                Console.WriteLine("Too many damn Locks!");
            }
            else
            {
                Locks.Add(@lock);
            }
        }
        protected virtual void GenerateLock()
        {
            switch (GetRandomLocktype())
            {
                case LOCKTYPE.INTEGRATED:
                    AddLockToLocks(new Integrated_Lock()); break;
                case LOCKTYPE.PADLOCK:
                    AddLockToLocks(new Padlock()); break;
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
