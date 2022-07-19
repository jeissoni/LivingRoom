using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingRoom.Entities.POCOs{

    //POCO: Son las siglas de Plain Old C# Object,
    //y se refieren a clases simples que no dependen de ninguna framework.
    //Es un término derivado del concepto del mundo Java: POJO.
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string? LastName { get; set; }

        public int? Age { get; set; }        

    }
}
