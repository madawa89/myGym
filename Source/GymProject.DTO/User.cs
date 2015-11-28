using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GymProject.DTO
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string MobileNumber { get; set; }
        public string LandNumber { get; set; }
        public UserType UserType { get; set; }
    }

    public enum UserType
    {
        Admin = 0,
        StaffMember = 1,
        Instructor = 2,
        Client = 3
    }
}
