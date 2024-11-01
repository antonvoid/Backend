namespace LearnBack.Component
{
    public class RoomDto
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public enum Type
        {
            economy, 
            standart, 
            luxury
        }
        public decimal Price { get; set; }
    }
}
