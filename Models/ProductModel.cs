
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace C_Mongo.Models
{
    public class ProductModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int Price { get; set; }

        public CategoriaProducto Categoria { get; set;}


    }
}
