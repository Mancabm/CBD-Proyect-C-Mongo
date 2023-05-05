
using System.ComponentModel;

namespace C_Mongo.Models
{
    public enum CategoriaProducto
    {
        [Description("Electrónica")]
        Electrónica,
        [Description("Cosméticos")]
        Cosméticos,
        [Description("Ropa")]
        Ropa,
        [Description("Deportes")]
        Deportes,
        [Description("Videojuegos")]
        Videojuegos
    }
}
