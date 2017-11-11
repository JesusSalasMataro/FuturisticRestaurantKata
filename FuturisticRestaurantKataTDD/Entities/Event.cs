namespace FuturisticRestaurantKataTDD.Entities
{
    public class Event
    {
        public int TableNumber { get; set; }

        public Event(int tableNumber)
        {
            TableNumber = tableNumber;
        }
    }
}
