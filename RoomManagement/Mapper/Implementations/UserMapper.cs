using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper.Implementations
{
    public class UserMapper
    {
        public Repository.Model.User MapToRepositoryModel(RoomManagement.Model.User model)
        {
            Repository.Model.User repositoryModel = new Repository.Model.User();

            repositoryModel.Id = model.Id;
            repositoryModel.Name = model.Name;

            return repositoryModel;
        }

        public RoomManagement.Model.User MapToModel(Repository.Model.User repositoryModel)
        {
            RoomManagement.Model.User model = new RoomManagement.Model.User();

            model.Id = repositoryModel.Id;
            model.Name = repositoryModel.Name;

            return model;

        }
    }
}
