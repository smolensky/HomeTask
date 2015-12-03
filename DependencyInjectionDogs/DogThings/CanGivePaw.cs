using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDogs.DogThings
{
    public class CanGivePaw : IPawGiving
    {
        public string GivePaw()
        {
            return "*Giving paw*";
        }
    }
}
