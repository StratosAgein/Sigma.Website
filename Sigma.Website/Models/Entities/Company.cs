using Sigma.Website.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sigma.Website.Models.Entities
{
    public class Company
    {
        public string _id { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public string OwnerClient { get; set; }
        public CompanyStatus CompanyStatus { get; set; }

    }
}