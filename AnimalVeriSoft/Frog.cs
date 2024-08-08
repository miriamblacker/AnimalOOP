using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalVeriSoft
{

    public class Frog : Animal, ILand, IWater
    {

        private int numberOfLegs = 4;

        public Frog() : base(false, false, 0)
        {
        }

        public Frog(int mood) : base(false, false, mood)
        {
        }

        public int GetNumberOfLegs()
        {
            return numberOfLegs;
        }

        public bool HasGills()
        {
            return false;
        }

        public bool HasLaysEggs()
        {
            return true;
        }

        public override void SayHello(int mood)
        {

            if (mood == MOOD_HAPPY)
            {
                Console.WriteLine("quack quack quack");
                return;
            }
            if (mood == MOOD_SCARE)
            {
                Console.WriteLine("plop into the water");
                return;
            }

            SayHello();

        }
    }
}
