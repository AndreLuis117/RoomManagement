using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper.Interfaces
{
    public interface IUserMapper
    {
        public Repository.Model.User MapToRepositoryModel(RoomManagement.Model.User model);

        public RoomManagement.Model.User MapToModel(Repository.Model.User repositoryModel);
    }
}
