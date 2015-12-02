using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DependencyInjectionDogs.DogThings;

namespace DependencyInjectionDogs.Dogs
{
    public class Dog
    {
        private readonly IBarking _barking;
        private readonly IStickBringing _stickBringing;
        private readonly IPawGiving _pawGiving;

        public Dog(IBarking barking, IPawGiving pawGiving, IStickBringing stickBringing)
        {
            _barking = barking;
            _stickBringing = stickBringing;
            _pawGiving = pawGiving;
        }

        public void DoDogThings()
        {
            IntroduceItself();
            _barking.Bark();
            _stickBringing.BringStick();
            _pawGiving.GivePaw();
            Console.WriteLine("\n");
        }

        public void IntroduceItself()
        {
            Console.WriteLine("I am " + MethodBase.GetCurrentMethod().DeclaringType.Name);
        }
    }
}
