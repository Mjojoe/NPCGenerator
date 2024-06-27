using DoorGenerator.Locks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DoorGenerator.Enums;

namespace DoorGenerator.Doors
{
    internal class Fabric_Door : Base_Door
    {
        public Fabric_Door()
        {
            Locks = new List<Lock>();
            GenerateOpenness();
            GenerateConstruction();
            GenerateLock();
        }
        override public void PrintDoor()
        {
            Console.WriteLine(Construction.ToString() + " Curtain");
            Console.WriteLine(Openness.ToString());
            foreach(Lock @lock in Locks)
            {
                @lock.PrintLock();
            }
        }
        internal override void GenerateOpenness() 
        {
            Openness = GetRandomOpenness(); 
            if(Openness == OPENNESS.HALFOPEN) { GenerateOpenness(); }
        }
        internal override void GenerateConstruction()
        {
            switch(GetRandomConstruction())
            {
                case CONSTRUCTION.SOLID:
                    Construction = CONSTRUCTION.SOLID; break;
                case CONSTRUCTION.DECREPID:
                    Construction = CONSTRUCTION.DECREPID; break;
                default:
                    GenerateConstruction();
                    break;
            }
        }
        protected override void GenerateLock()
        {
            Locks.Add(new NoLock());
        }
    }
}
