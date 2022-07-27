using System.ComponentModel;

namespace LivingRoom.DTOs
{
    public class CreateUserDTO
    {
        public int Id { get; set; }
        public int? IdUser { get; set; }
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public Genders Gender { get; set; }
        public OccupationDTO Occupation { get; set; }
        public int CellPhoneNumber { get; set; }
        public string Email { get; set; }

        [DefaultValue("false")]
        public bool Leader { get; set; }

        [DefaultValue("false")]
        public bool Support { get; set; }

        [DefaultValue("false")]
        public bool Attendee { get; set; }

        public UserAddressDTO? Address { get; set; }
    }

    public enum Days
    {
        Lunes,
        Martes,
        Miercoles,
        Jueves,
        Viernes,
        Sabado,
        Domingo
    }

    public enum Genders
    {
        Men,
        Woman
    }

    public enum MaritalStatus
    {
        Casado_a,
        Soltero_a,
        Divorciado_a,
        Viudo_a,
        UnionLibre,
        Otro
    }
}
