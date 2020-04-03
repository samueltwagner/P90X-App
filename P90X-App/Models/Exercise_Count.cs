using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace P90X_App.Models
{
    public class Exercise_Count
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Exercise_Count_Id { get; set; }
        public int Reps { get; set; }

        public int Weight { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string User { get; set;}

        [BsonRepresentation(BsonType.ObjectId)]
        public string Exercise {get; set;}

    }
}