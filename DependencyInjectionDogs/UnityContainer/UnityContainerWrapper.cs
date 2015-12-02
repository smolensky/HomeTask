using DependencyInjectionDogs.Dogs;
using DependencyInjectionDogs.DogThings;
using Microsoft.Practices.Unity;

namespace DependencyInjectionDogs.UnityContainer
{
    internal class UnityContainerWrapper
    {
        public static Microsoft.Practices.Unity.UnityContainer GetUnityContainer()
        {
            var container = new Microsoft.Practices.Unity.UnityContainer();

            container
                .RegisterType<IBarking, BarkingLoud>("BarkingLoud")
                .RegisterType<IBarking, BarkingQuiet>("BarkingQuiet")
                .RegisterType<IPawGiving, CanGivePaw>("CanGivePaw")
                .RegisterType<IPawGiving, CantGivePaw>("CantGivePaw")
                .RegisterType<IStickBringing, CanBringStick>("CanBringStick")
                .RegisterType<IStickBringing, CantBringStick>("CantBringStick")

                .RegisterType<Dog>("Chihuahua",
                    new InjectionConstructor(container.Resolve<IBarking>("BarkingQuiet"),
                        container.Resolve<IPawGiving>("CantGivePaw"),
                        container.Resolve<IStickBringing>("CantBringStick")))
                .RegisterType<Dog>("Ovcharka",
                    new InjectionConstructor(container.Resolve<IBarking>("BarkingLoud"),
                        container.Resolve<IPawGiving>("CanGivePaw"),
                        container.Resolve<IStickBringing>("CanBringStick")))
                .RegisterType<Dog>("Rotveller",
                    new InjectionConstructor(container.Resolve<IBarking>("BarkingQuiet"),
                        container.Resolve<IPawGiving>("CanGivePaw"),
                        container.Resolve<IStickBringing>("CantBringStick"))); ;

            return container;
        }
    }
}
