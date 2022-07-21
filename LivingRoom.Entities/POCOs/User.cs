using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingRoom.Entities.POCOs{

    //POCO: Son las siglas de Plain Old C# Object,
    //y se refieren a clases simples que no dependen de ninguna framework.
    //Es un término derivado del concepto del mundo Java: POJO.
    public class User
    {
        [Key]
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

        public UserAddress Address { get; set; }


    }
}
