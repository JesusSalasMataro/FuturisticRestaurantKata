using FuturisticRestaurantKataTDD.Contracts;
using FuturisticRestaurantKataTDD.Implementations;
using System.Collections.Generic;

namespace FuturisticRestaurantKataTDD.Entities
{
    public abstract class Subject
    {
        private List<Observer> _services;

        public Subject()
        {
            _services = new List<Observer>();
        }

        public void Attach(Observer service)
        {
            _services.Add(service);
        }

        protected void NotifyAll(Event e)
        {
            foreach (Observer service in _services)
            {
                if (service is MetreService)
                {
                    if (e.Vip)
                    {
                        service.activate(e);
                    }
                }
                else
                {
                    service.activate(e);
                }                
            }
        }
    }
}
