using GymProject.Business;
using GymProject.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace GymProject.Portal.Models
{
    public class RegisterViewModel : User
    {
        internal bool CreateUser()
        {
            UserProvider up = new UserProvider();
            User user = this as User;

            if (user == null)
                return false;

            return up.CreateUser(user);
        }
    }
}