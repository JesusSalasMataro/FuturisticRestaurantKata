using FuturisticRestaurantKataTDD.Contracts;
using FuturisticRestaurantKataTDD.Entities;
using System;

namespace FuturisticRestaurantKataTDD.Implementations
{
    public class WaiterService : Observer
    {
        public void activate(Event e)
        {
            Console.WriteLine("Activado servicio de camarero para la mesa " + e.TableNumber);
        }
    }
}
