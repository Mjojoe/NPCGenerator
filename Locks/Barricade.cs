using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Random random = new Random();
            switch (random.Next(2))
            {
                case 0:
                    BarricadeType = Enums.BARRICADETYPE.PLANK;
                    GenerateIfLockIsLocked(); break;
                case 1:
                    BarricadeType = Enums.BARRICADETYPE.CLUTTER; break;
                default:
                    throw new ArgumentException("Beats me what happened ¯\\_(ツ)_/¯");
            }
        }
    }
}
