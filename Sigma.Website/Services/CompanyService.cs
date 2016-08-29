using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
            string jsonResult = await _connection.GetDataAsync("GetCompanyById", HttpComposedParameters.Of("CompanyId", companyId));
            dynamic result = JObject.Parse(jsonResult);
            JObject companyObj = (JObject)result.Company;

            return companyObj.ToObject<Company>();
        }

        public async Task<IEnumerable<Company>> GetAllCompanies()
        {
            string jsonResult = await _connection.GetDataAsync("GetAllCompanies");
            dynamic result = JObject.Parse(jsonResult);
            JArray companiesArray = (JArray)result.Companies;
            
            return companiesArray.ToObject<IEnumerable<Company>>();
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