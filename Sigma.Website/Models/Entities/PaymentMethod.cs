using Sigma.Website.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sigma.Website.Models.Entities
{
    public class PaymentMethod
    {
        public string _id { get; set; }
        public PaymentMethodStatus PaymentMethodStatus { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public PaymentMethodType PaymentMethodType { get; set; }
    }
}