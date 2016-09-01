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
            string jsonResult = await _connection.PostData("CreateCompany",
                HttpSimpleParameters.Of("ShortName", company.ShortName),
                HttpSimpleParameters.Of("LongName", company.LongName),
                HttpSimpleParameters.Of("OwnerClient", company.OwnerClient),
                HttpSimpleParameters.Of("RegisterTime", company.RegisterTime.ToString()));

            dynamic result = JObject.Parse(jsonResult);
            return result.Success;
        }

        public async Task<bool> EditCompany(Company company)
        {
            string jsonResult = await _connection.PostData("EditCompany",
                HttpSimpleParameters.Of("Id", company._id),
                HttpSimpleParameters.Of("ShortName", company.ShortName),
                HttpSimpleParameters.Of("LongName", company.LongName),
                HttpSimpleParameters.Of("OwnerClient", company.OwnerClient),
                HttpSimpleParameters.Of("CompanyStatus", company.CompanyStatus.ToString()),
                HttpSimpleParameters.Of("RegisterTime", company.RegisterTime.ToString()));

            dynamic result = JObject.Parse(jsonResult);
            
            return result.Success;
        }

        public async Task<bool> DeleteCompany(string companyId)
        {
            string jsonResult = await _connection.PostData("DeleteCompany",
                HttpSimpleParameters.Of("Id", companyId));

            dynamic result = JObject.Parse(jsonResult);

            return result.Success;
        }
    }
}