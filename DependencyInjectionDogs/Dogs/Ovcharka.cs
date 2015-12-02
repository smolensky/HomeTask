using DependencyInjectionDogs.DogThings;

namespace DependencyInjectionDogs.Dogs
{
    public class Ovcharka : Dog
    {
        private readonly IBarking _barking;
        private readonly IStickBringing _stickBringing;
        private readonly IPawGiving _pawGiving;

        public Ovcharka(IBarking barking, IPawGiving pawGiving, IStickBringing stickBringing) 
            : base(barking, pawGiving, stickBringing)
        {
            _barking = barking;
            _stickBringing = stickBringing;
            _pawGiving = pawGiving;
        }
    }
}