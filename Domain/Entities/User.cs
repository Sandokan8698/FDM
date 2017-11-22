using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User
    {
        public int UserId { get; set; }

        [Required]
        [MaxLength(50)]
        [DisplayName("Nombre Usuario")]
        public string UserName { get; set; }

        [Required]
        [MaxLength(50)]
        [DisplayName("Contraseña")]
        public string Password { get; set; }


        [Required]
        [MaxLength(50)]
        [DisplayName("Email")]
        public string UserEmailAddress { get; set; }

        
    }
}
