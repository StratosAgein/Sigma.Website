using Sigma.Website.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sigma.Website.Models.Entities
{
    public class Client
    {
        public string _id { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public ClientStatus ClientStatus { get; set; }
        public PaymentMethod PaymentMehod { get; set; }
        public string DocumentNumber { get; set; }
        public DocumentType? DocumentType { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime RegisterTime { get; set; }
    }
}