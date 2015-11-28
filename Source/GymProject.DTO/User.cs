using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace GymProject.DTO
{
    public class User
    {
        public int UserId { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("Gender")]
        public string Gender { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Address")]
        public string Address { get; set; }

        [DisplayName("Date Of Birth")]
        public DateTime DateOfBirth { get; set; }

        [DisplayName("Mobile Number")]
        public string MobileNumber { get; set; }

        [DisplayName("Land Phone Number")]
        public string LandNumber { get; set; }

        [DisplayName("Username")]
        public string Username { get; set; }

        [DisplayName("Password")]
        public string Password { get; set; }

        [DisplayName("User Type")]
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
