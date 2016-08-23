using Newtonsoft.Json;
using Sigma.Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Sigma.Website.Services
{
    public class CompanyService
    {
        private ConnectionService _connection;

        public CompanyService()
        {
            _connection = new ConnectionService();
        }

        public async Task<bool> CreateCompany(Company company)
        {
            var addEquipo = JsonConvert.SerializeObject(company);
            return true;
        }
    }
}