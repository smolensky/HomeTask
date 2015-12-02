using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDogs.DogThings
{
    class BarkingLoud : IBarking
    {
        public void Bark()
        {
            Console.WriteLine("BARK!!! BARK!!!");
        }
    }
}
