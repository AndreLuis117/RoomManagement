using Microsoft.AspNetCore.Mvc;
using Model.Api;
using Repository.Data;
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


        public UserController
            (IUserService userService
            )
        {
            _userService = userService;
        }


        [HttpGet]
        public IEnumerable<User> Get()
        {           
            return _userService.GetAll();
        }
    }
}
