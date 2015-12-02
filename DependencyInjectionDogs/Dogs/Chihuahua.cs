using DependencyInjectionDogs.DogThings;

namespace DependencyInjectionDogs.Dogs
{
    public class Chihuahua : Dog
    {
        private readonly IBarking _barking;
        private readonly IStickBringing _stickBringing;
        private readonly IPawGiving _pawGiving;

        public Chihuahua(IBarking barking, IPawGiving pawGiving, IStickBringing stickBringing) 
            : base(barking, pawGiving, stickBringing)
        {
            _barking = barking;
            _stickBringing = stickBringing;
            _pawGiving = pawGiving;
        }
    }
}