using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDogs.DogThings
{
    class CantBringStick : IStickBringing
    {
        public void BringStick()
        {
            Console.WriteLine("*Can't bring stick*");
        }
    }
}
