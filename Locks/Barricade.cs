using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoorGenerator;

namespace DoorGenerator.Locks
{
    internal class Barricade : Lock
    {
        Enums.BARRICADETYPE BarricadeType {  get; set; } 
        public Barricade()
        {
            IsLocked = true;
            GenerateBarricadeTypeForBarricade();
        }
        public Barricade(Enums.BARRICADETYPE barricadeType, bool locked)
        {
            BarricadeType = barricadeType;
            IsLocked = locked;
        }

        public override void PrintLock()
        {
            Console.WriteLine("Barricaded with "+ BarricadeType.ToString());
            if(BarricadeType == Enums.BARRICADETYPE.PLANK)
            {
                if(IsLocked)
                {
                    Console.WriteLine("The Plank is not fastend.");
                }
                else
                {
                    Console.WriteLine("The Plank is fastend");
                }
                
            }
        }
        void GenerateBarricadeTypeForBarricade()
        {
            switch (Enums.GetRandomBarricadeType())
            {
                case Enums.BARRICADETYPE.PLANK:
                    BarricadeType = Enums.BARRICADETYPE.PLANK;
                    GenerateIfLockIsLocked(); break;
                case Enums.BARRICADETYPE.CLUTTER:
                    BarricadeType = Enums.BARRICADETYPE.CLUTTER; break;
                default:
                    throw new ArgumentException("Beats me what happened ¯\\_(ツ)_/¯");
            }
        }
    }
}
