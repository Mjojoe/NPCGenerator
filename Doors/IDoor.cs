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
        public Enums.OPENNESS Openness { get; }
        public Enums.CONSTRUCTION Construction { get; }
        public List<Lock> Locks { get; }
        public void PrintDoor();
    }
}
