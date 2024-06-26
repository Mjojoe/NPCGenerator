using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorGenerator.Locks
{
    internal class Lock
    {
        public bool IsLocked { get; set; }
        public void PrintLock() { }
        internal void GenerateIfLockIsLocked()
        {
            Random random = new Random();
            switch (random.Next(2))
            {
                case 0:
                    IsLocked = true; break;
                case 1:
                    IsLocked = false; break;
                default:
                    throw new ArgumentException("Beats me what happened ¯\\_(ツ)_/¯");
            }
        }
    }
}
