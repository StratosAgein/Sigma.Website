using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sigma.Website.Models
{
    public class User
    {
        public string _id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public float Status { get; set; }
        public string Phone { get; set; }
        public Role[] Roles { get; set; }
        public float age { get; set; }
    }

    public class Role
    {
        public string Group { get; set; }
        public bool IsPrimary { get; set; }
    }
}