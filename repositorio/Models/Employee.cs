using System.ComponentModel.DataAnnotations.Schema;
using repositorio.Models;

namespace repositorio.Models
{
    public class Employee : BaseEntity 
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dui { get; set; }
        public string NumeroTelefonico { get; set; }

        [ForeignKey("TypeEmployee")]
        public int TypeEmployeeId { get; set; }
        public TypeEmployee? TypeEmployee { get; set; }
        public object IsActive { get; internal set; }
    }
}
