using Sigma.Website.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sigma.Website.Models.Entities
{
    public class BalanceScoreCard
    {
        public string _id { get; set; }
        public BalanceScoreCardStatus BalanceScoreCardStatus { get; set; }
        public DateTime RegisterTime { get; set; }
        public string Name { get; set; }
        public OrganizationalUnit OrganizationalUnit { get; set; }
    }
}