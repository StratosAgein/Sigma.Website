﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sigma.Website.Models.Entities
{
    public class OrganizationalUnit
    {
        public string _id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime RegisterTime { get; set; }
    }
}