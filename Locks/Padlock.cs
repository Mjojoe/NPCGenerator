using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorGenerator.Locks
{
    internal class Padlock : Lock
    {
        public Padlock() 
        {
            GenerateIfLockIsLocked();
        }
        public Padlock(bool locked)
        {
            IsLocked = locked;
        }
        public override void PrintLock()
        {
            if (IsLocked)
            {
                Console.WriteLine("Locked  Padlock");
            }
            else
            {
                Console.WriteLine("Unlocked Padlock");
            }
        }
    }
}
