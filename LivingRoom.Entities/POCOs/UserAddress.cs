namespace LivingRoom.Entities.POCOs
{
    public class UserAddress
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Neighborhood { get; set; }

        public City City { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
