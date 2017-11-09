using FuturisticRestaurantKata.Contracts;
using System;

namespace FuturisticRestaurantKata.Implementations
{
    public class MetreService : Observer
    {
        public void activate(Event e)
        {
            Console.WriteLine("Metre going to table " + e.TableNumber);          
        }
    }
}
