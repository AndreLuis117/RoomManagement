using Repository.Model;
using Repository.Repository;
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

        public UserService
            (
            IUserRepository userRepository
            )
        {
            _userRepository = userRepository;   
        }

        public void Insert()
        {
            User user = new User { Id = 1, Name = "André Luis Cardoso" };

            _userRepository.Add(user);
        }
    }
}
