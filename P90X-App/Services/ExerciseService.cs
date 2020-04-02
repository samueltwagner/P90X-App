using P90X_App.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace P90X_App.Services
{
    public class ExerciseService
    {
        private readonly IMongoCollection<Exercise> _exercises;

        public ExerciseService(IP90X_AppDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase("P90X_App");

            _exercises = database.GetCollection<Exercise>("exercises");
        }

        public List<Exercise> Get() =>
            _exercises.Find(exercise => true).ToList();

        public Exercise Get(string id) =>
            _exercises.Find<Exercise>(exercise => exercise.Id == id).FirstOrDefault();

        public void Update(string id, Exercise exerciseIn) =>
            _exercises.ReplaceOne(exercise => exercise.Id == id, exerciseIn);

    }
}