using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace P90X_App.Models
{
    public class TotalSynergistics
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string ExerciseTitle { get; set; }

        public string Reps { get; set; }

        public string Weight { get; set; }

        public string Side { get; set; }

        public string WorkoutStatus { get; set; }

        public string DietStatus { get; set; }

        public WorkoutBlock WorkoutBlock { get; set;}
    }
}