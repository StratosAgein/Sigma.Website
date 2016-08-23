using Newtonsoft.Json;
using Sigma.Website.Models;
using Sigma.Website.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Sigma.Website.Services
{
    public class UserService
    {
        private ConnectionService _connection;
        private User _user;

        public User User
        {
            get { return _user; }
            set { _user = value; }
        }

        public UserService()
        {
            _connection = new ConnectionService();
        }

        public async Task<Authenticate> AuthenticateUser(string Email, string Password)
        {
            string authenticateData = await _connection.GetDataAsync("Authenticate", HttpComposedParameters.Of("Email", Email), HttpComposedParameters.Of("Password", Password));
            Authenticate authenticateObj = JsonConvert.DeserializeObject<Authenticate>(authenticateData);
            return authenticateObj;
        }


    }
}