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

        public async Task<User> GetUserById(string UserId)
        {
            string jsonResult = await _connection.GetDataAsync("GetUserById", HttpComposedParameters.Of("UserId", UserId));
            dynamic result = JObject.Parse(jsonResult);
            JObject userObj = (JObject)result.User;

            return userObj.ToObject<User>();
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            string jsonResult = await _connection.GetDataAsync("GetAllUser");
            dynamic result = JObject.Parse(jsonResult);
            JArray companiesArray = (JArray)result.Users;

            return companiesArray.ToObject<IEnumerable<User>>();
        }

        public async Task<bool> CreateUser(User User)
        {
            string UserSerialized = JsonConvert.SerializeObject(User);
            return true;
        }

        public async Task<bool> EditUser(User User)
        {
            string UserSerialized = JsonConvert.SerializeObject(User);
            return true;
        }

        public async Task<bool> DeleteUser(string UserId)
        {
            return true;
        }
    }
}