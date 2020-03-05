using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace P90X_App.Models
{
    public class WorkoutBlock
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Week { get; set; }

        public int Week_Count { get; set; }

        public string Day { get; set; }

        public int Day_Count { get; set; }

        public string Month { get; set; }

        public int Month_Count { get; set; }

        public DateTime Date { get; set; }

    }
}