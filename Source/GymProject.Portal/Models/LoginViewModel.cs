using GymProject.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymProject.Portal.Models
{
    public class LoginViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Remember { get; set; }

        internal object GetUser()
        {
            UserProvider up = new UserProvider();
            return up.GetUser(this.Username, this.Password);
        }
    }
}