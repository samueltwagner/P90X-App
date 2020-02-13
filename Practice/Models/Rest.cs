using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace P90X_App.Models
{
    public class Rest
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string WorkoutStatus { get; set; }

        public string DietStatus { get; set; }

        public WorkoutBlock WorkoutBlock { get; set;}
    }
}