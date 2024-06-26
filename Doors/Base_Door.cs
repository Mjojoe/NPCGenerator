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
        public void PrintDoor() { }
        protected void GenerateOpenness()
        {
            Openness = GetRandomOpenness();
        }
        protected void GenerateConstruction()
        {
            Construction = GetRandomConstruction();
        }
        protected void AddLockToLocks(Lock @lock)
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
        protected void GenerateLock()
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
