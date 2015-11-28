using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymProject.Portal.Models
{
    public class RegisterViewModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string MobileNumber { get; set; }
        public string LandNumber { get; set; }
    }
}