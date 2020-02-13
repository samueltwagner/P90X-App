using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace P90X_App.Models
{
    public class WorkoutBlock
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string BlockId { get; set; }

        public string Week { get; set; }

        public string Day { get; set; }

        public string Month { get; set; }

        public DateTime Date { get; set; }

    }
}