using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorGenerator
{
    internal class Door
    {
        public Enums.OPENNESS Openess { get; set; }
        public Enums.MATERIAL Material { get; set; }
        public Enums.CONSTRUCTION Construction { get; set; }
        public List<Enums.LOCKED> Locked { get; set; }
        //private Locktype LockType { get; set; }

        public Door()
        {
            Locked = new List<Enums.LOCKED>();
            
        }

        public Door(int locks) 
        {
            Locked = new List<Enums.LOCKED>();
            //NumOfLocks = (locks%3);
        }

        public void printDoor()
        {
            Console.WriteLine(Openess.ToString());
            Console.WriteLine(Material.ToString());
            Console.WriteLine(Construction.ToString());
            foreach(Enums.LOCKED locks in Locked)
            {
                Console.WriteLine(locks.ToString());
            }
        }
        public void generateOpeness()
        {
            Array values = Enums.getOpenArray();
            Random random = new Random();
            Openess = (Enums.OPENNESS)values.GetValue(random.Next(values.Length));
        }
        public void generateMaterial()
        {
            Array values = Enum.GetValues(typeof(Enums.MATERIAL));
            Random random = new Random();
            Material = (Enums.MATERIAL)values.GetValue(random.Next(values.Length));
        }
        public void generateConstruction()
        {
            Array values = Enum.GetValues(typeof(Enums.CONSTRUCTION));
            Random random = new Random();
            Construction = (Enums.CONSTRUCTION)values.GetValue(random.Next(values.Length));
            if (Material == Enums.MATERIAL.GLASS || Material == Enums.MATERIAL.FABRIC)
            {
                if (Construction == Enums.CONSTRUCTION.BARS || Construction == Enums.CONSTRUCTION.WINDOWED)
                {
                    Construction = Enums.CONSTRUCTION.DECREPID;
                }
            }
        }
        public void GenerateLocks()
        {
            int NumOfLocks = new Random().Next(3);
            for (int i = 0; i <= NumOfLocks; i++)
            {
                generateLocked();
            }
        }
        void generateLocked()
        {
            if (Material == Enums.MATERIAL.FABRIC)
            {
                Locked.Add(Enums.LOCKED.UNLOCKED);
            }
            else
            {
                Array values = Enum.GetValues(typeof(Enums.LOCKED));
                Random random = new Random();
                //LOCKED lock = (LOCKED)values.GetValue(random.Next(values.Length));
                Locked.Add((Enums.LOCKED)values.GetValue(random.Next(values.Length)));

            }

        }
            //void generateLocktype()
            //{
            //    Array values = Enum.GetValues(typeof(Locktype));
            //    Random random = new Random();
            //    LockType = (Locktype)values.GetValue(random.Next(values.Length));
            //    if (Locked == Locked.MULTIPLE)
            //    {

            //    }
            //    if (Locked == Locked.BARRED)
            //    {

            //    }
            //    if (Locked == Locked.UNLOCKED)
            //    {

            //    }
            //    if (Locked == Locked.LOCKED)
            //    {

            //    }
            //}

    }
}
