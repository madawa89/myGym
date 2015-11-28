using GymProject.DataAccess;
using GymProject.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GymProject.Business
{
    public class UserProvider
    {
        UserDataProvider userDataProvider = null;

        public UserProvider()
        {
            userDataProvider = new UserDataProvider();  
        }

        public bool CreateUser(User user)
        {                        
            return userDataProvider.CreateUser(user);
        }

        public User GetUser(string username, string password)
        {
            return userDataProvider.GetUser(username, password);
        }
    }
}
