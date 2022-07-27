namespace LivingRoom.Entities.POCOs
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<City> City { get; set; }

    }
}
