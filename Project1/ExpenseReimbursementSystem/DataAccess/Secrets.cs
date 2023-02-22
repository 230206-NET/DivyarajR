internal class Secrets{
    private string _connectionString = "Server=tcp:tracker-for-workout.database.windows.net,1433;Initia Catalog=workoutDB; Persist Security Info=False;User ID=workout-admin;Password=dicode04!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
    public string getConnectionString() => _connectionString;
}