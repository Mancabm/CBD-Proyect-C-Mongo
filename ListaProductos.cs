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
        public ListaProductos()
        {
            InitializeComponent();
            InitializeData();
        }

        private async void InitializeData()
        {
            ProductDataAccess productDB = new ProductDataAccess();
            List<ProductModel> products = await productDB.GetAllProducts();
            listadoProductos.ColumnCount = 4;
            listadoProductos.Columns[0].Name = "Name";
            listadoProductos.Columns[1].Name = "Description";
            listadoProductos.Columns[2].Name = "Price";
            listadoProductos.Columns[3].Name = "Categories";
            foreach(ProductModel product in products)
            {
                string[] row = { product.Name, product.Description, 
                    (product.Price.ToString() + '€'), product.Categoria.ToString()};
                listadoProductos.Rows.Add(row);
            }
        }
       
    }
}
