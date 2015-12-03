using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDogs.DogThings
{
    public class BarkingQuiet : IBarking
    {
        public string Bark()
        {
            return "bark";
        }
    }
}
