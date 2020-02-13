using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace WorkoutApp.Models
{
    public class Workout
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string WorkoutId { get; set; }
        public string WorkoutTitle { get; set; }
    }
}