using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDogs.DogThings
{
    public class CantBringStick : IStickBringing
    {
        public string BringStick()
        {
            return "*Can't bring stick*";
        }
    }
}
