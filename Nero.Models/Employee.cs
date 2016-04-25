﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Nero.Models
{
    public class Employee
    {
        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("Email Address")]
        public string EmailAddress { get; set; }

        [DisplayName("Biography")]
        public string Biography { get; set; }
    }
}