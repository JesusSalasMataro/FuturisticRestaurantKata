using FuturisticRestaurantKata.Implementations;
using System.Collections.Generic;

namespace FuturisticRestaurantKata.Contracts
{
    public abstract class Subject
    {
        private List<Observer> _observers;

        public Subject()
        {
            _observers = new List<Observer>();
        }

        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyAll(Event e)
        {
            foreach (Observer observer in _observers)
            {
                observer.activate(e);
            }
        }
    }
}
