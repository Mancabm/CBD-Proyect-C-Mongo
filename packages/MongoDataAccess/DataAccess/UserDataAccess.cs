using MongoDataAccess.Models;
using MongoDB.Driver;


namespace MongoDataAccess.DataAccess
{
    public class UserDataAccess
    {
        private const string ConnectionString = "mongodb://localhost:27017";
        private const string DatabaseName = "ProyectoCBD-MongoDbyC#";
        private const string Userscollection = "Clientes";

        private IMongoCollection<T> ConnectToMongo<T>(in string collection)
        {
            var client = new MongoClient(ConnectionString);
            var db = client.GetDatabase(DatabaseName);
            return db.GetCollection<T>(collection);
        }

        private async Task<List<UserModel>> GetAllUsers()
        {
            var userscollection = ConnectToMongo<UserModel>(Userscollection);
            var results = await userscollection.FindAsync( _ => true);
            return results.ToList();

        }

        public Task CreateUser(UserModel user)
        {
            var userscollection = ConnectToMongo<UserModel>(Userscollection);
            return userscollection.InsertOneAsync(user);
        }
            
           
    }

}   

    

