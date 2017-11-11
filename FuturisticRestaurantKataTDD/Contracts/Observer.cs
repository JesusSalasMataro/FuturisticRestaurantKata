using FuturisticRestaurantKataTDD.Entities;

namespace FuturisticRestaurantKataTDD.Contracts
{
    public interface Observer
    {
        void activate(Event e);
    }
}
