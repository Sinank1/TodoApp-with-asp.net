using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TodoApp.Models;

namespace TodoApp.Controllers
{
    [Authorize(Roles = "admin")]
    public class UsersController:Controller
    {
        private UserManager<Models.AppUser> _userManager;
        private RoleManager<AppRole> _roleManager;
        public UsersController(UserManager<AppUser>  userManager, RoleManager<AppRole> roleManager)

        {
            _userManager = userManager;
            _roleManager = roleManager; 
        }

        public IActionResult Index()
        {
            return View(_userManager.Users);
        }

       
        

    }

}