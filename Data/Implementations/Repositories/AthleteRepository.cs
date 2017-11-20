
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
    }
}
