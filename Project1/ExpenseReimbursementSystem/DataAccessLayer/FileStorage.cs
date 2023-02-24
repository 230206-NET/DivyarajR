using System.Text.Json;

namespace DataAccessLayer;

public class FileStorage : IRepository
{
    private const string _filePath = "../DataAccessLayer/Users.json";
    public FileStorage()
    {
        bool fileExists = File.Exists(_filePath);
        if(!fileExists) {
            var fs = File.Create(_filePath);
            fs.Close();
        }
    }

    
}
