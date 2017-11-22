using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Data.Abstract.Repositories
{
    public interface IUserRepository: IRepository<User>
    {
        User GetUserByUserName(string userName, string passWord);

        User GetUserByUserName(string userName);
    }
}
