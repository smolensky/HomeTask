using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjectionDogs.Dogs;
using DependencyInjectionDogs.UnityContainer;
using Microsoft.Practices.Unity;

namespace DependencyInjectionDogs
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog1 = UnityContainerWrapper.GetUnityContainer().Resolve<Dog>("Chihuahua");
            var dog2 = UnityContainerWrapper.GetUnityContainer().Resolve<Dog>("Rotveller");
            var dog3 = UnityContainerWrapper.GetUnityContainer().Resolve<Dog>("Ovcharka");

            dog1.DoDogThings();
            dog2.DoDogThings();
            dog3.DoDogThings();

            Console.ReadLine();
        }
    }
}
