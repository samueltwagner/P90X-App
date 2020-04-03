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
        public string Workout_Id { get; set; }

        public string WorkoutTitle {get; set;}

        public bool Status_Workout { get; set; }

        public bool Status_Diet { get; set; }

        public int DayNumber { get; set; }
        public int WeekNumber { get; set; }

        public int BlockNumber { get; set; }
        public DateTime Date_Workout_Completed { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string[] Exercise {get; set;}

        // public string[] Exercises {get; set;}    

        [BsonRepresentation(BsonType.ObjectId)]
        public string User { get; set;}
    }
}