using P90X_App.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace P90X_App.Services
{
    public class Exercise_CountService
    {
        private readonly IMongoCollection<Exercise_Count> _exercise_counts;

        public Exercise_CountService(IP90X_AppDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase("P90X_App");

            _exercise_counts = database.GetCollection<Exercise_Count>("exercise_counts");
        }

        public List<Exercise_Count> Get() =>
            _exercise_counts.Find(exercise_count => true).ToList();

        public Exercise_Count Get(string id) =>
            _exercise_counts.Find<Exercise_Count>(exercise_count => exercise_count.Id == id).FirstOrDefault();

        public void Update(string id, Exercise_Count exercise_countIn) =>
            _exercise_counts.ReplaceOne(exercise_count => exercise_count.Id == id, exercise_countIn);

    }
}