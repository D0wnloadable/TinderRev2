﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TinderRev2.Models
{
    public class ProfileModel
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public char Gender { get; set; }
    }
}
