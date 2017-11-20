
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Data.Abstract;
using Domain;
using Domain.Entities;

namespace Data.Implementations.Repositories
{
    public class AthleteRepository : DomainContextRepository<Athlete>,IAthleteRepository
    {
        public AthleteRepository(FDMContext context) : base(context)
        {
        }

        public override IEnumerable<Athlete> GetAll()
        {
            return FDMContext.AthleteDbSet.Include(a => a.Sport).ToList();
        }
    }
}
