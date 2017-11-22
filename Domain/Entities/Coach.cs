using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Coach
    {
        public int CoachId { get; set; }

        public int SportId { get; set; }

        [DisplayName("Deporte")]
        public Sport Sport { get; set; }

        [Required]
        [MaxLength(100)]
        [DisplayName("Nombre")]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        [DisplayName("Apellidos")]
        public string LatName { get; set; }

        [Required]
        [DisplayName("Cedula")]
        public int CI { get; set; }


        [Required]
        [DisplayName("Canton")]
        public string HomeTown { get; set; }
        

    }
}
