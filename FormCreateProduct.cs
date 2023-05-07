using System;
using System.Windows.Forms;
using C_Mongo.Models;
using C_Mongo.MongoDataAccess;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C_Mongo
{
    
    public partial class FormCreateProduct : Form
    {
        


        private List<UserModel> users;
        private List<string> userNames;

        public FormCreateProduct()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
           

        }

  
        private async void AñadirProducto_Click(object sender, EventArgs e)
        {
            
            string nombre = name.Text.Trim();
            string description = descripcion.Text.Trim();
            int price = (int)numericUpDown1.Value;
            ProductDataAccess db = new ProductDataAccess();
            var Categorias = categoryBox.SelectedItems;
            List<CategoriaProducto> categoriasSeleccionadas = new List<CategoriaProducto>();
            foreach( var categoria in Categorias)
            {
                var categoriaSeleccionada = (CategoriaProducto)Enum.Parse(typeof(CategoriaProducto), categoria.ToString());
                categoriasSeleccionadas.Add(categoriaSeleccionada);
            }

          
            var producto = new ProductModel
            {
                Name = nombre,
                Description = description,
                Price = price,
                Categorias= categoriasSeleccionadas,
            };

           
            try
            {
                await db.CreateProduct(producto);
                MessageBox.Show($"Se ha guardado el producto");
                Close();
              
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error al guardar el producto");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
