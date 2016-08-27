using Sigma.Website.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sigma.Website.Models.Entities
{
    public class Perspective
    {
        public PerspectiveStatus PerspectiveStatus { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public DateTime RegisterTime { get; set; }
    }
}