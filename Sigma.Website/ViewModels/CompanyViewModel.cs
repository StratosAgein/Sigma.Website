using Sigma.Website.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sigma.Website.ViewModels
{
    public class CompanyViewModel
    {
        public string _id { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public string OwnerClient { get; set; }
        public DateTime RegisterTime { get; set; }
        public CompanyStatus CompanyStatus { get; set; }
    }
}