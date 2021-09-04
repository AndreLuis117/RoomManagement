using Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Model;

namespace Repository.Repository
{
    public interface IUserRepository : IRepository<User>
    {
    }
}
