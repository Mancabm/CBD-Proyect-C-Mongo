using C_Mongo.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;

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

        public async Task<List<ProductModel>> DeleteProduct()
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

        public Task UpdateProduct(ProductModel product)
        {
            var productsCollection = ConnectToMongo<ProductModel>(Productscollection);
            var filter = Builders<ProductModel>.Filter.Eq("Id",product.Id);
            return productsCollection.ReplaceOneAsync(filter,product, new ReplaceOptions { IsUpsert= true });
        }
        public Task DeleteProduct(ProductModel product)
        {
            var productsCollection = ConnectToMongo<ProductModel>(Productscollection);
            return productsCollection.DeleteOneAsync(c => c.Id == product.Id);
        }

        public  ProductModel GetProductByID(string id)
        {
            var productsCollection = ConnectToMongo<ProductModel>(Productscollection);
            var filter = Builders<ProductModel>.Filter.Eq(product => product.Id , id);
            var result =  productsCollection.Find(filter).FirstOrDefault();
            return result;
        }


    }
}
