namespace LivingRoom.Entities.POCOs
{
    public class LivingGroup
    {
     
        public int Id { get; set; }

        public virtual City City { get; set; }

        public string Address { get; set; }

        public int MinAge { get; set; }

        public int MaxAge { get; set; }

        public Days Day { get; set; }

        public string Description { get; set; }

        public List<User> Users { get; set; }

        public enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
