using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace P90X_App.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string User_Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public int StartingWeight { get; set; }

        public int CurrentWeight { get; set; }
    }
}
