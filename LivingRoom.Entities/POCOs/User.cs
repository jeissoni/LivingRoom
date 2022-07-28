using System.ComponentModel;

namespace LivingRoom.Entities.POCOs
{

    //POCO: Son las siglas de Plain Old C# Object,
    //y se refieren a clases simples que no dependen de ninguna framework.
    //Es un término derivado del concepto del mundo Java: POJO.
    public class User
    {       
        public int Id { get; set; }
        public int? IdUser { get; set; }
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }   
        public Genders Gender { get; set; }


        public int OccupationForeignKey { get; set; }
        public Occupation Occupation { get; set; }

        public int SegmentationForeignKey { get; set; }
        public Segmentation Segmentation { get; set; }

        public int SchoolGradeForeignKey { get; set; }
        public SchoolGrade SchoolGrade { get; set; }

        public int CellPhoneNumber { get; set; }
        public string Email { get; set; }

        [DefaultValue("false")]
        public bool Leader { get; set; }

        [DefaultValue("false")]
        public bool Support { get; set; }

        [DefaultValue("false")]
        public bool Attendee { get; set; }
        public bool Sons { get; set; }
        public int NumberOfChildren { get; set; }
        public Days[] DaysAvailable { get; set; }

        public int UserAddressForeignKey { get; set; }
        public UserAddress UserAddress { get; set; }

        public int LivingGroupForeignKey { get; set; }
        public LivingGroup LivingGroup { get; set; }

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
}
