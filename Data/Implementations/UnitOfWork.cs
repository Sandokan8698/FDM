using System;
using Data.Abstract;
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
        }

        public IAthleteRepository AthleteRepository { get; private set; }

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
