﻿using C_Mongo.MongoDataAccess;
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
            foreach(ProductModel product in products)
            {
                string categorias = "";
                for (var indexer = 0; indexer < product.Categorias.Count; indexer++)
                {
                    categorias = categorias + product.Categorias[0].ToString();
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
