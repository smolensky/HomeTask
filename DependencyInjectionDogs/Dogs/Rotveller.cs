using DependencyInjectionDogs.DogThings;

namespace DependencyInjectionDogs.Dogs
{
    public class Rotveller : Dog
    {
        private readonly IBarking _barking;
        private readonly IStickBringing _stickBringing;
        private readonly IPawGiving _pawGiving;

        public Rotveller(IBarking barking, IPawGiving pawGiving, IStickBringing stickBringing) 
            : base(barking, pawGiving, stickBringing)
        {
            _barking = barking;
            _stickBringing = stickBringing;
            _pawGiving = pawGiving;
        }
    }
}