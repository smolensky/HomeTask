using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDogs.DogThings
{
    public class CanBringStick : IStickBringing
    {
        public string BringStick()
        {
            return "*Giving stick*";
        }
    }
}
