using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SpaDay.Models
{
    public class User
    {


        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; }

        public string VerifyPasswed { get; }


        public User(string userName, string email, string password)
        {
            UserName = userName;
            Email = email;
            Password = password;
        }

    }
}