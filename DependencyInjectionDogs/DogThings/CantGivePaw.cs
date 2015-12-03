using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDogs.DogThings
{
    public class CantGivePaw : IPawGiving
    {
        public string GivePaw()
        {
            return "*Can't give paw*";
        }
    }
}
