using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Authorization;

namespace Domain.Entities
{
    [Table("Worker")]
    public class Worker: AppUser
    {
        public bool IsGay { get; set; }
    }
}
