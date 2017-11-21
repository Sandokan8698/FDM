using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Athlete
    {
        public int AthleteId { get; set; }

        [Required]
        [MaxLength(100)]
        [DisplayName("Nombre")]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string FatherSurName { get; set; }

        [Required]
        [MaxLength(50)]
        public string MotherSurName { get; set; }

        [Required]
        public int Sexo { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime BirthDate { get; set; }

        [Required]
        public int CI { get; set; }

        public int SportId { get; set; }

        [DisplayName("Deporte")]
        public Sport Sport { get; set; }

        [Required]
        [MaxLength(100)]
        public string HomeTown { get; set; }

        [MaxLength(100)]
        public string Address { get; set; }

        [Phone]
        public string HomePhone { get; set; }

        [Phone]
        public string CelularPhone { get; set; }

        [MaxLength(100)]
        public string EducativeUnit { get; set; }

        [MaxLength(50)]
        public string Year { get; set; }

        [MaxLength(50)]
        public string Pararell { get; set; }

        [MaxLength(100)]
        public string Rector { get; set; }


        public decimal Weight { get; set; }

        public decimal Height { get; set; }

        [Column(TypeName = "date")]
        public DateTime BeginDate { get; set; }

        public int? RepresentantId { get; set; }

        public Representant Representant { get; set; }
    }
}
