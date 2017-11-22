using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Abstract.Repositories;
using Domain.Entities;

namespace Data.Implementations.Repositories
{
    public class CoachRepository : DomainContextRepository<Coach>, ICoachRepostitory
    {
        public CoachRepository(FDMContext context) : base(context)
        {
        }
    }
}
