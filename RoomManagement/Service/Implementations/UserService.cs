using Mapper.Interfaces;
using Model.Api;
using Repository.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserMapper _userMapper;

        public UserService
            (
            IUserRepository userRepository,
            IUserMapper userMapper
            )
        {
            _userRepository = userRepository;
            _userMapper = userMapper;
        }

        public void Add(User user)
        {

            var userMapped = _userMapper.MapToRepositoryModel(user);
            _userRepository.Add(userMapped);
        }

        public void Delete(User user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            var usersList = _userRepository.GetAll();

            List<User> usersListMapped = new List<User>();

            foreach (var user in usersList)
            {
                usersListMapped.Add(_userMapper.MapToModel(user));
            }

            return usersListMapped;
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }
    }
    
}
