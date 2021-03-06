using System;
using Data.Abstract.Repositories;

namespace Data.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IAthleteRepository AthleteRepository { get; }
        ISportRepository SportRepository { get; }
        ICoachRepostitory CoachRepostitory { get; }
        IUserRepository UserRepository { get; }
     
        int Complete();
    }
}