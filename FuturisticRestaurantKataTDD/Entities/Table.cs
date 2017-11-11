using FuturisticRestaurantKataTDD.Contracts;
namespace FuturisticRestaurantKataTDD
{
    public class Table
    {
        private Observer _waiterService;
        private Observer _menuService;

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

        public Table(Observer waiterService, Observer menuService)
        {
            _waiterService = waiterService;
            _menuService = menuService;
        }
    }
}
