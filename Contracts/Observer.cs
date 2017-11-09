using FuturisticRestaurantKata.Implementations;
namespace FuturisticRestaurantKata.Contracts
{
    public interface Observer
    {
        void activate(Event e);
    }
}
