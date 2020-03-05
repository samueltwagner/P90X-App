using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace P90X_App.Models
{
    public class Workout
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string WorkoutTitle {get; set;}
        public string ExerciseTitle { get; set; }

        public int Reps { get; set; }

        public float Weight { get; set; }

        public string Side { get; set; }

        public string WorkoutStatus { get; set; }

        public string DietStatus { get; set; }

        public WorkoutBlock WorkoutBlock { get; set;}
    }
}