using FuturisticRestaurantKata.Contracts;
using FuturisticRestaurantKata.Enums;

namespace FuturisticRestaurantKata.Implementations
{
    public class Table : Subject
    {
        private Status _status;

        public Status Status 
        { 
            get 
            {
                return _status;
            }
            set
            {
                _status = value;

                if (_status == Status.Busy)
                {
                    Event e = new Event
                    {
                        TableNumber = Number
                    };

                    NotifyAll(e);
                }                
            }
        }

        public bool Vip { get; set; }

        public int Number { get; set; }

        public Table(int number, bool vip)
            : base()
        {
            Number = number;
            Vip = vip;
        }
    }
}
