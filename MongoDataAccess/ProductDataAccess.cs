using C_Mongo.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

namespace C_Mongo.MongoDataAccess
{
    public class ProductDataAccess
    {
        private const string ConnectionString = "mongodb://localhost:27017";
        private const string DatabaseName = "ProyectoCBD-MongoDbyC#";
        private const string Productscollection = "Productos";
        private const string Categoriascollection = "Categorias";
        private IMongoCollection<T> ConnectToMongo<T>(in string collection)
        {
            var client = new MongoClient(ConnectionString);
            var db = client.GetDatabase(DatabaseName);
            return db.GetCollection<T>(collection);
        }

        public async Task<List<ProductModel>> GetAllProducts()
        {
            var productsCollection = ConnectToMongo<ProductModel>(Productscollection);
            var results = await productsCollection.FindAsync(_ => true);
            return results.ToList();

        }

        public Task CreateProduct(ProductModel product)
        {
            var productsCollection = ConnectToMongo<ProductModel>(Productscollection);
            return productsCollection.InsertOneAsync(product);
        }

        public async Task<List<CategoriaProducto>> GetAllCategorias()
        {
            var categoriasCollection = ConnectToMongo<CategoriaProducto>(Categoriascollection);
            var results = await categoriasCollection.FindAsync(_ => true);
            return results.ToList();
        }

        public async Task<List<ProductModel>> GetProductsByCategory(CategoriaProducto category)
        {
            var productCollection = ConnectToMongo<ProductModel>(Productscollection);
            var filter = Builders<ProductModel>.Filter
                .AnyEq(product => product.Categorias, category);
            return await productCollection.Find(filter).ToListAsync();
        }

    }
}
