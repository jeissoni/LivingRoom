namespace LivingRoom.Entities.POCOs
{
    public class Occupation
    {
        public int Id { get; set; } 

        public string Name { get; set; }    

        public User User { get; set; }  
    }
}
