using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Sport
    {
        public int SportId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
