using FuturisticRestaurantKataTDD.Contracts;
using FuturisticRestaurantKataTDD.Entities;
using System;

namespace FuturisticRestaurantKataTDD.Implementations
{
    public class ElectronicMenuService : Observer
    {
        public void activate(Event e)
        {
            Console.WriteLine("Activado servicio de menú para la mesa " + e.TableNumber);
        }
    }
}
