using Microsoft.AspNetCore.Mvc;
using Repository.Data;
using RoomManagement.Model;
using Service.Service;
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
        public AppDbContext _context;


        public UserController
            (//UserService userService
            AppDbContext context
            )
        {
            //_userService = userService;
            _context = context;
        }


        [HttpGet]
        public IEnumerable<User> Get()
        {
            IEnumerable<User> users;

            List<User> usersList = new List<User>();

            User user = new User { Id = 1, Name = "André Luis Cardoso" };

            usersList.Add(user);

            users = usersList;

            _userService.Insert();

            return users;
        }
    }
}
