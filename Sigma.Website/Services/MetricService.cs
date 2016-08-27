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
    public class MetricService
    {
        private ConnectionService _connection;

        public MetricService()
        {
            _connection = new ConnectionService();
        }

        public async Task<Metric> GetMetricById(string MetricId)
        {
            string result = await _connection.GetDataAsync("GetMetricById", HttpComposedParameters.Of("Id", MetricId));
            Metric MetricObj = JsonConvert.DeserializeObject<Metric>(result);
            return MetricObj;
        }

        public async Task<IEnumerable<Metric>> GetAllMetrics()
        {
            string result = await _connection.GetDataAsync("GetAllMetrics");
            IEnumerable<Metric> companiesObj = JsonConvert.DeserializeObject<IEnumerable<Metric>>(result);
            return companiesObj;
        }

        public async Task<bool> CreateMetric(Metric Metric)
        {
            string MetricSerialized = JsonConvert.SerializeObject(Metric);
            return true;
        }

        public async Task<bool> EditMetric(Metric Metric)
        {
            string MetricSerialized = JsonConvert.SerializeObject(Metric);
            return true;
        }

        public async Task<bool> DeleteMetric(string MetricId)
        {
            return true;
        }
    }
}