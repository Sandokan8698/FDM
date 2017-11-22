using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Abstract.Repositories;
using Domain.Entities;

namespace Data.Implementations.Repositories
{
    public class UserRepository: DomainContextRepository<User>, IUserRepository
    {
        public UserRepository(FDMContext context) : base(context)
        {
        }

        public User GetUserByUserName(string userName, string passWord)
        {
            var user = SingleOrDefault(u => u.UserName == userName && u.Password == passWord);
            return user;
        }

        public User GetUserByUserName(string userName)
        {
            var user =  SingleOrDefault(u => u.UserName == userName);
            return user;
        }
    }
}
