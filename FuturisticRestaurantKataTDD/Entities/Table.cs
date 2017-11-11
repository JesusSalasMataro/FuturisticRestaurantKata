using FuturisticRestaurantKataTDD.Contracts;
using System.Collections.Generic;
namespace FuturisticRestaurantKataTDD
{
    public class Table
    {
        private List<Observer> _services;

        private TableStatusEnum _status { get; set; }

        public TableStatusEnum Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;

                if (value == TableStatusEnum.Occupied)
                {
                    NotifyAll();
                }
            }
        }

        public Table()
        {
            _services = new List<Observer>();
        }

        public void Attach(Observer service) 
        {
            _services.Add(service);
        }

        private void NotifyAll()
        {
            foreach (Observer service in _services)
            {
                service.activate();
            }
        }
    }
}
