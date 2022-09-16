using DataAccessLibrary.Models;

namespace DataAccessLibrary;

public class UserData : IUserData
{
    private readonly ISqlDataAccess _db;

    public UserData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<List<UserModel>> GetUser()
    {
        string sql = "SELECT * FROM Master.[User]";
        
        return _db.LoadData<UserModel, dynamic>(sql, new { });
    }
}