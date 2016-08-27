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
    public class BalanceScoreCardService
    {
        private ConnectionService _connection;

        public BalanceScoreCardService()
        {
            _connection = new ConnectionService();
        }

        public async Task<BalanceScoreCard> GetCompanyById(string BalanceScoreCardId)
        {
            string result = await _connection.GetDataAsync("GetCompanyById", HttpComposedParameters.Of("Id", BalanceScoreCardId));
            BalanceScoreCard balanceScoreCardObj = JsonConvert.DeserializeObject<BalanceScoreCard>(result);
            return balanceScoreCardObj;
        }

        public async Task<IEnumerable<BalanceScoreCard>> GetAllBalanceScoreCard()
        {
            string result = await _connection.GetDataAsync("GetAllBalanceScoreCard");
            IEnumerable<BalanceScoreCard> balancesObj = JsonConvert.DeserializeObject<IEnumerable<BalanceScoreCard>>(result);
            return balancesObj;
        }

        public async Task<bool> CreateCompany(BalanceScoreCard company)
        {
            string companySerialized = JsonConvert.SerializeObject(company);
            return true;
        }

        public async Task<bool> EditCompany(BalanceScoreCard company)
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