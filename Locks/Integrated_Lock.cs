using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorGenerator.Locks
{
    internal class Integrated_Lock : Lock
    {
        public Integrated_Lock() 
        {
            GenerateIfLockIsLocked();
        }
        public Integrated_Lock(bool locked)
        {
            IsLocked = locked;
        }
        public override void PrintLock()
        {
            if (IsLocked)
            {
                Console.WriteLine("Locked intergrated Lock");
            }
            else
            {
                Console.WriteLine("Unlocked integrated Lock");
            }
        }
    }
}
