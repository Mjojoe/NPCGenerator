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
        public Barricade(Enums.BARRICADETYPE barricadeType)
        {
            BarricadeType = barricadeType;
        }

        public new void PrintLock()
        {
            Console.WriteLine("The Barricade is made with "+ BarricadeType.ToString());
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
