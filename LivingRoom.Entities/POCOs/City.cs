namespace LivingRoom.Entities.POCOs
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryForeignKey { get; set; }
        public Country Country { get; set; }

    }
}
