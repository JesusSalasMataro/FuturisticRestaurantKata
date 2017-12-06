using FuturisticRestaurantKataTDD.Contracts;
using FuturisticRestaurantKataTDD.Entities;
using System.Collections.Generic;

namespace FuturisticRestaurantKataTDD
{
    public class Table : Subject
    {
        public int Number { get; set; }
        public bool Vip { get; set; }

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
                    Event e = new Event(tableNumber: Number, isVip: Vip);
                    NotifyAll(e);
                }
            }
        }

        public Table(int tableNumber, bool isVip)
            : base()
        {
            Number = tableNumber;
            Vip = isVip;
        }
    }
}
