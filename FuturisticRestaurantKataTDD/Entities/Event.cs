namespace FuturisticRestaurantKataTDD.Entities
{
    public class Event
    {
        public int TableNumber { get; set; }
        public bool Vip { get; set; }

        public Event(int tableNumber, bool isVip)
        {
            TableNumber = tableNumber;
            Vip = isVip;
        }
    }
}
