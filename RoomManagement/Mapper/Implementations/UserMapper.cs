using Mapper.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper.Implementations
{
    public class UserMapper : IUserMapper
    {
        public Repository.Model.User MapToRepositoryModel(Model.Api.User model)
        {
            Repository.Model.User repositoryModel = new Repository.Model.User();

            repositoryModel.Id = model.Id;
            repositoryModel.Name = model.Name;
            repositoryModel.CreatedDate = model.CreatedDate;
            repositoryModel.ModifiedDate = model.ModifiedDate;
            repositoryModel.ExclusionDate = model.ExclusionDate;

            return repositoryModel;
        }

        public Model.Api.User MapToModel(Repository.Model.User repositoryModel)
        {
            Model.Api.User model = new Model.Api.User();

            model.Id = repositoryModel.Id;
            model.Name = repositoryModel.Name;
            model.CreatedDate = repositoryModel.CreatedDate;
            model.ModifiedDate = repositoryModel.ModifiedDate;
            model.ExclusionDate = repositoryModel.ExclusionDate;

            return model;

        }
    }
}
