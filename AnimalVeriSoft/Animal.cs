using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalVeriSoft
{
    public abstract class Animal
    {

        protected bool mammals;

        protected bool carnivorous;

        public const int MOOD_HAPPY = 1;

        public const int MOOD_SCARE = 2;

        protected int mood;

        public Animal(bool mammals, bool carnivorous, int mood)
        {

            this.mammals = mammals;
            this.carnivorous = carnivorous;
            this.mood = mood;

        }

        public virtual void SayHello()
        {
            Console.WriteLine("Nothing....");
        }

        public abstract void SayHello(int mood);

        public bool IsMammal()
        {
            return mammals;
        }

        public bool IsCarnivorous()
        {
            return carnivorous;
        }

    }
}
