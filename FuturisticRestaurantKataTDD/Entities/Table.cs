using FuturisticRestaurantKataTDD.Contracts;
namespace FuturisticRestaurantKataTDD
{
    public class Table
    {
        private IWaiterService _waiterService;
        private IElectronicMenuService _menuService;

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
                    _menuService.activate();
                }
            }
        }

        public Table(IWaiterService waiterService, IElectronicMenuService menuService)
        {
            _waiterService = waiterService;
            _menuService = menuService;
        }
    }
}
