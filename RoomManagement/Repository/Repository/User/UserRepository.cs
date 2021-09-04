using Repository.Data;
using Repository.Generic;
using Repository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository
            (
                AppDbContext context
            ) : base(context)
        {
                
        }
    }
}
