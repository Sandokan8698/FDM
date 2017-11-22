using System;
using Data.Abstract;
using Data.Abstract.Repositories;
using Data.Implementations.Repositories;
using Domain;

namespace Data.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FDMContext _context;

        public UnitOfWork(FDMContext context)
        {
            _context = context;
            AthleteRepository = new AthleteRepository(context);
            SportRepository = new SportRepository(context);
            CoachRepostitory = new CoachRepository(context);
            UserRepository = new UserRepository(context);
        }

        public IAthleteRepository AthleteRepository { get; private set; }
        public ISportRepository SportRepository { get; private set; }
        public ICoachRepostitory CoachRepostitory { get; private set; }
        public IUserRepository UserRepository { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
