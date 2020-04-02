using P90X_App.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace P90X_App.Services
{
    public class UserService
    {
        private readonly IMongoCollection<User> _users;

        public UserService(IP90X_AppDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase("P90X_App");

            _users = database.GetCollection<User>("users");
        }

        public List<User> Get() =>
            _users.Find(users => true).ToList();

        public User Get(string id) =>
            _users.Find<User>(user => user.Id == id).FirstOrDefault();

        public void Update(string id, User userIn) =>
            _users.ReplaceOne(user => user.Id == id, userIn);

    }
}