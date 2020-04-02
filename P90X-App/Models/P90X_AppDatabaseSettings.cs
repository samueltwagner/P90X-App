namespace P90X_App.Models
{
    public class P90X_AppDatabaseSettings : IP90X_AppDatabaseSettings
    {
        public string WorkoutCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IP90X_AppDatabaseSettings
    {
        string WorkoutCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}