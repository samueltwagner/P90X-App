using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace P90X_App.Models
{
    public class Exercise
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Exercise_Id { get; set; }
        public string Exercise_Title { get; set; }

    }
}