using Microsoft.AspNetCore.Mvc;
using Repository.Data;
using RoomManagement.Model;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IUserMapper _mapper;


        public UserController
            (IUserService userService
            )
        {
            _userService = userService;
        }


        [HttpGet]
        public IEnumerable<User> Get()
        {
            IEnumerable<User> users;

            List<User> usersList = new List<User>();

            User user = new User { Id = 1, Name = "André Luis Cardoso" };

            //usersList.Add(user);

            var users1 = _userService.GetAll();

            foreach (var item in users1)
            {
                usersList.Add()
            }
            

            return users;
        }
    }
}
