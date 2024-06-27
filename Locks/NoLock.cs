using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorGenerator.Locks
{
    internal class NoLock : Lock
    {
        public NoLock() 
        {
            IsLocked = false;
        }
        public override void PrintLock()
        {
            Console.WriteLine("There is no Lock");
        }
    }
}
