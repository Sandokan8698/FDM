using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Authorization;

namespace Domain.Entities
{
    [Table("Coach")]
    public class Coach: AppUser
    {
        [Required(ErrorMessage = "El campo deporte es requerido")]
        public int SportId { get; set; }

        [DisplayName("Deporte")]
        public Sport Sport { get; set; }

        [Required(ErrorMessage = "El campo nombre es requerido")]
        [MaxLength(100)]
        [DisplayName("Nombre")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El campo apellidos es requerido")]
        [MaxLength(100)]
        [DisplayName("Apellidos")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "El campo cedula es requerido")]
        [DisplayName("Cedula")]
        public int CI { get; set; }


        [Required(ErrorMessage = "El campo canton es requerido")]
        [DisplayName("Canton")]
        public string HomeTown { get; set; }
        

    }
}
