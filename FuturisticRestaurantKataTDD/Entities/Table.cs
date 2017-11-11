using FuturisticRestaurantKataTDD.Contracts;
using FuturisticRestaurantKataTDD.Entities;
using System.Collections.Generic;

namespace FuturisticRestaurantKataTDD
{
    public class Table : Subject
    {
        public int Number { get; set; }

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
                    Event e = new Event(tableNumber: Number);
                    NotifyAll(e);
                }
            }
        }

        public Table(int tableNumber)
            : base()
        {
            Number = tableNumber;
        }
    }
}
