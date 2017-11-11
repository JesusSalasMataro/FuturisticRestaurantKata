using FuturisticRestaurantKataTDD.Contracts;
namespace FuturisticRestaurantKataTDD
{
    public class Table
    {
        private IWaiterService _waiterService;

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
                    _waiterService.activate();
                }
            }
        }

        public Table(IWaiterService waiterService)
        {
            _waiterService = waiterService;
        }
    }
}
