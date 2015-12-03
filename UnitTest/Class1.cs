using DependencyInjectionDogs.DogThings;
using Xunit;

namespace UnitTest
{
    public class Class1
    {
        private readonly BarkingLoud _barkingLoud = new BarkingLoud();
        private readonly BarkingQuiet _barkingQuiet = new BarkingQuiet();
        private readonly CanGivePaw _canGivePaw = new CanGivePaw();
        private readonly CantGivePaw _cantGivePaw = new CantGivePaw();
        private readonly CanBringStick _canBringStick = new CanBringStick();
        private readonly CantBringStick _cantBringStick = new CantBringStick();

        [Fact]
        private void Should_Bark_Loud()
        {
            Assert.Equal(_barkingLoud.Bark(), "BARK!!! BARK!!!");
        }

        [Fact]
        private void Should_Bark_Quiet()
        {
            Assert.Equal(_barkingQuiet.Bark(), "bark");
        }

        [Fact]
        private void Should_Give_Paw()
        {
            Assert.Equal(_canGivePaw.GivePaw(), "*Giving paw*");
        }

        [Fact]
        private void Should_Not_Give_Paw()
        {
            Assert.Equal(_cantGivePaw.GivePaw(), "*Can't give paw*");
        }

        [Fact]
        private void Should_Bring_Stick()
        {
            Assert.Equal(_canBringStick.BringStick(), "*Giving stick*");
        }

        [Fact]
        private void Should_Not_Bring_Stick()
        {
            Assert.Equal(_cantBringStick.BringStick(), "*Can't bring stick*");
        }

        [Fact]
        private void Should_Fail_All_Times()
        {
            Assert.Equal(1, 0);
        }
    }
}
