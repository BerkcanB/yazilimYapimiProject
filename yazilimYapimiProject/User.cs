using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazilimYapimiProject
{
    public class User : UserType
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string TCNumber { get; set; }
        public string TelNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int UserID { get; set; }
        public string Password { get; set; }

       // UserType userType = new UserType();
    }
}