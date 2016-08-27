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
    public class PerspectiveService
    {
        private ConnectionService _connection;

        public PerspectiveService()
        {
            _connection = new ConnectionService();
        }

        public async Task<Perspective> GetPerspectiveById(string PerspectiveId)
        {
            string result = await _connection.GetDataAsync("GetPerspectiveById", HttpComposedParameters.Of("Id", PerspectiveId));
            Perspective PerspectiveObj = JsonConvert.DeserializeObject<Perspective>(result);
            return PerspectiveObj;
        }

        public async Task<IEnumerable<Perspective>> GetAllPerspective()
        {
            string result = await _connection.GetDataAsync("GetAllPerspective");
            IEnumerable<Perspective> companiesObj = JsonConvert.DeserializeObject<IEnumerable<Perspective>>(result);
            return companiesObj;
        }

        public async Task<bool> CreatePerspective(Perspective Perspective)
        {
            string PerspectiveSerialized = JsonConvert.SerializeObject(Perspective);
            return true;
        }

        public async Task<bool> EditPerspective(Perspective Perspective)
        {
            string PerspectiveSerialized = JsonConvert.SerializeObject(Perspective);
            return true;
        }

        public async Task<bool> DeletePerspective(string PerspectiveId)
        {
            return true;
        }
    }
}