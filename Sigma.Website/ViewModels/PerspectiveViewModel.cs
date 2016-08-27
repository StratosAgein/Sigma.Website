using Sigma.Website.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sigma.Website.ViewModels
{
    public class PerspectiveViewModel
    {
        public string _id { get; set; }
        public PerspectiveStatus PerspectiveStatus { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public DateTime RegisterTime { get; set; }
    }
}