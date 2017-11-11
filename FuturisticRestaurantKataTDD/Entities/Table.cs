using FuturisticRestaurantKataTDD.Contracts;
using FuturisticRestaurantKataTDD.Entities;
using System.Collections.Generic;

namespace FuturisticRestaurantKataTDD
{
    public class Table : Subject
    {
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
    }
}
