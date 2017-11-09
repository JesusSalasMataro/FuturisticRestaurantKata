using FuturisticRestaurantKata.Contracts;
using System;

namespace FuturisticRestaurantKata.Implementations
{
    public class ElectronicMenuService : Observer
    {
        public void activate(Event e)
        {
            Console.WriteLine("Activating electronic menu in table " + e.TableNumber);
        }
    }
}
