using System.ComponentModel;

namespace LivingRoom.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }
        public int? IdUser { get; set; }
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public string? Occupation { get; set; }
        public int CellPhoneNumber { get; set; }
        public string Email { get; set; }

        [DefaultValue("false")]
        public bool Leader { get; set; }

        [DefaultValue("false")]
        public bool Support { get; set; }

        [DefaultValue("false")]
        public bool Attendee { get; set; }

        public UserAddressDTO Address { get; set; }
    }
}
