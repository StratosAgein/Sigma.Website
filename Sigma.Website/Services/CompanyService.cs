using Newtonsoft.Json;
using Sigma.Website.Models.Entities;
using Sigma.Website.Utils;
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

        public async Task<Company> GetCompanyById(string companyId)
        {
            string result = await _connection.GetDataAsync("GetCompanyById", HttpComposedParameters.Of("Id", companyId));
            Company companyObj = JsonConvert.DeserializeObject<Company>(result);
            return companyObj;
        }

        public async Task<IEnumerable<Company>> GetAllCompanies()
        {
            string result = await _connection.GetDataAsync("GetAllCompanies");
            IEnumerable<Company> companiesObj = JsonConvert.DeserializeObject<IEnumerable<Company>>(result);
            return companiesObj;
        }

        public async Task<bool> CreateCompany(Company company)
        {
            string companySerialized = JsonConvert.SerializeObject(company);
            return true;
        }

        public async Task<bool> EditCompany(Company company)
        {
            string companySerialized = JsonConvert.SerializeObject(company);
            return true;
        }

        public async Task<bool> DeleteCompany(string companyId)
        {
            return true;
        }
    }
}