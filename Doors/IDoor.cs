using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoorGenerator.Locks;

namespace DoorGenerator.Doors
{
    internal interface IDoor
    {
        Enums.OPENNESS Openness { get; }
        Enums.CONSTRUCTION Construction { get; }
        List<Lock> Locks { get; }
        public void PrintDoor();
    }
}
