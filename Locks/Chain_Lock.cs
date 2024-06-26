using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DoorGenerator.Enums;

namespace DoorGenerator.Locks
{
    internal class Chain_Lock : Lock
    {
        public Chain_Lock()
        {
            GenerateIfLockIsLocked();
        }    
    }
}
