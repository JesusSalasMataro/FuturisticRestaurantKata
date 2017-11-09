using FuturisticRestaurantKata.Contracts;
using System;

namespace FuturisticRestaurantKata.Implementations
{
    public class WaiterService : Observer
    {
        public void activate(Event e)
        {
            Console.WriteLine("Waiter going to table " + e.TableNumber);
        }
    }
}
