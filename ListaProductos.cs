using C_Mongo.MongoDataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C_Mongo.Models;

namespace C_Mongo
{
    public partial class ListaProductos : Form
    {
        public string categoryAttribute { get; set; }
        public ListaProductos()
        {
            InitializeComponent();
            InitializeData();
        }
        public ListaProductos(string categoryProduct)
        {
            InitializeComponent();
            this.categoryAttribute = categoryProduct;
            InitializeData();
        }

        private async void InitializeData()
        {
            List<ProductModel> products = new List<ProductModel>();
            ProductDataAccess productDB = new ProductDataAccess();
            if (categoryAttribute == null)
            {
                products = await productDB.GetAllProducts();
            }
            else
            {
                products = await productDB.GetProductsByCategory((CategoriaProducto)Enum.Parse(typeof(CategoriaProducto), categoryAttribute.ToString()));
            }
            foreach(ProductModel product in products)
            {
                string categorias = "";
                for (var indexer = 0; indexer < product.Categorias.Count; indexer++)
                {
                    categorias = categorias + product.Categorias[indexer].ToString();
                    if (indexer < product.Categorias.Count - 1)
                    {
                        categorias = categorias + ", ";
                    }
                }
                string[] row = {product.Id, product.Name, product.Description, product.Price +"€",
                    categorias, "Update", "Delete"};
                listadoProductos.Rows.Add(row);

            }
        }

    }
}
