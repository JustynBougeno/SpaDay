using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;


namespace SpaDay.Controllers 
{
    public class UserController : Controller
    {
        [Route("/user/add")]

        public IActionResult Add()
        {
            return View();
        }

    public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            
            if (newUser.Password == verify)
            {
                ViewBag.userName = newUser.UserName;
                return View("index");
            }
            else
            {
                return Redirect("/user/");
            }
        }

    }
}
