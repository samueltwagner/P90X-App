using P90X_App.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace P90X_App.Services
{
    public class WorkoutService
    {
        private readonly IMongoCollection<Workout> _workouts;

        public WorkoutService(IP90X_AppDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase("P90X_App");

            _workouts = database.GetCollection<Workout>("workouts");
        }

        public List<Workout> Get() =>
            _workouts.Find(workout => true).ToList();

        public Workout Get(string id) =>
            _workouts.Find<Workout>(workout => workout.Id == id).FirstOrDefault();

        public void Update(string id, Workout workoutIn) =>
            _workouts.ReplaceOne(workout => workout.Id == id, workoutIn);

    }
}