using FuturisticRestaurantKataTDD.Contracts;
using FuturisticRestaurantKataTDD.Entities;
using System;

namespace FuturisticRestaurantKataTDD.Implementations
{
    public class MetreService : Observer
    {
        public virtual void activate(Event e)
        {
            Console.WriteLine("Activado servicio de metre para la mesa " + e.TableNumber);
        }
    }
}
