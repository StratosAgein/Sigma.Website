using Newtonsoft.Json;
using Sigma.Website.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Sigma.Website.Services
{
    public class ConnectionService
    {
        public HttpClient _client;
        private string _serviceUri;
        public ConnectionService()
        {
            _client = new HttpClient();
            _serviceUri = "http://localhost:3000/api";
        }

        public async Task<string> PostData(string action, params KeyValuePair<string, string>[] HttpParameters)
        {
            string uri = string.Format("{0}/{1}", _serviceUri, action);

            HttpClient client = new HttpClient();

            HttpContent keyValues = new FormUrlEncodedContent(HttpPostEncodedBuilder(HttpParameters));

            var response = await client.PostAsync(uri, keyValues);
            
            string content = await response.Content.ReadAsStringAsync();
            return content;
        }

        public async Task<string> GetDataAsync(string action)
        {
            string uri = string.Format("{0}/{1}", _serviceUri, action);
            return await _client.GetStringAsync(uri);
        }

        public async Task<string> GetDataAsync(string action, params KeyValuePair<string, object>[] HttpParameters)
        {
            string uri = string.Format("{0}/{1}{2}", _serviceUri, action, HttpParametersBuilder(HttpParameters));
            return await _client.GetStringAsync(uri);
        }
        
        private IEnumerable<KeyValuePair<string, string>> HttpPostEncodedBuilder(KeyValuePair<string, string>[] httpParameters)
        {
            List<KeyValuePair<string, string>> keyValues = new List<KeyValuePair<string, string>>();
            for (int i = 0; i < httpParameters.Length; i++)
            {
                keyValues.Add(httpParameters[i]);
            }
            return keyValues;
        }

        private string HttpPostParametersBuilder(KeyValuePair<string, object>[] httpParameters)
        {
            string stringParameters = "[";

            for (int i = 0; i < httpParameters.Length; i++)
            {
                stringParameters += "{";
                stringParameters += httpParameters[i].Key + ":" + httpParameters[i].Value;
                stringParameters += "}";
                if (i < httpParameters.Length - 1)
                {
                    stringParameters += ",";
                }
            }

            stringParameters += "]";

            return stringParameters;
        }

        private string HttpParametersBuilder(KeyValuePair<string, object>[] httpParameters)
        {
            string stringParameters = String.Empty;

            for (int i = 0; i < httpParameters.Length; i++)
            {
                if (i==0)
                {
                    stringParameters = "?";
                }
                stringParameters += httpParameters[i].Key + "=" + httpParameters[i].Value + "&";
            }
            stringParameters = stringParameters.Remove(stringParameters.Length - 1);

            return stringParameters;
        }
        
    }
}