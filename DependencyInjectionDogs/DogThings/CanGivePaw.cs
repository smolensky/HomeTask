using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDogs.DogThings
{
    class CanGivePaw : IPawGiving
    {
        public void GivePaw()
        {
            Console.WriteLine("*Giving paw*");
        }
    }
}
