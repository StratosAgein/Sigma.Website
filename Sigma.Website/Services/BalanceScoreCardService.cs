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
    public class BalanceScoreCardService
    {
        private ConnectionService _connection;

        public BalanceScoreCardService()
        {
            _connection = new ConnectionService();
        }

        public async Task<BalanceScoreCard> GetBalanceScoreCardById(string BalanceScoreCardId)
        {
            string result = await _connection.GetDataAsync("GetBalanceScoreCardById", HttpComposedParameters.Of("Id", BalanceScoreCardId));
            BalanceScoreCard balanceScoreCardObj = JsonConvert.DeserializeObject<BalanceScoreCard>(result);
            return balanceScoreCardObj;
        }

        public async Task<IEnumerable<BalanceScoreCard>> GetAllBalanceScoreCard()
        {
            string resultText = await _connection.GetDataAsync("GetAllBalanceScoreCard");
            dynamic result = JObject.Parse(resultText);
            JArray companiesArray = (JArray)result.Balances;

            return companiesArray.ToObject<IEnumerable<BalanceScoreCard>>();
        }

        public async Task<bool> CreateBalanceScoreCard(BalanceScoreCard BalanceScoreCard)
        {
            string BalanceScoreCardSerialized = JsonConvert.SerializeObject(BalanceScoreCard);
            return true;
        }

        public async Task<bool> EditBalanceScoreCard(BalanceScoreCard BalanceScoreCard)
        {
            string BalanceScoreCardSerialized = JsonConvert.SerializeObject(BalanceScoreCard);
            return true;
        }

        public async Task<bool> DeleteBalanceScoreCard(string BalanceScoreCardId)
        {
            return true;
        }
    }
}