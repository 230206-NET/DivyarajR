namespace DataAccess;

internal class Secrets
{
    private const string connection = "Server=tcp:ers-db.database.windows.net,1433;Initial Catalog=ERS;Persist Security Info=False;User ID=ers-admin;Password=dicode04!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
    
    public static string getConnectionString() => connection;
}