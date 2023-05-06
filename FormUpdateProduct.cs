using C_Mongo.Models;
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

namespace C_Mongo
{
    public partial class FormUpdateProduct : Form
    {

       public ProductModel model { get; set; }
        public FormUpdateProduct(ProductModel product)
        {
            InitializeComponent();
            this.model = product;
            InicializarDatos();

        }
        public FormUpdateProduct()
        {
            InitializeComponent();
           

        }


        public void InicializarDatos()
        {
            textBox1.Text = model.Name;
            textBox2.Text = model.Description;
            numericUpDown1.Value = model.Price;
            List<string> categories = model.Categorias.Select(c => c.ToString()).ToList();
            foreach (string category in categories)
            {
                categoryBox4.SelectedItems.Add(category);
            }
        }

        public async void updateButton_click(object sender, EventArgs e)
        {
            ProductDataAccess productDB = new ProductDataAccess();
            string nombre = textBox1.Text.Trim();
            string description = textBox2.Text.Trim();
            int price = (int)numericUpDown1.Value;
            ProductDataAccess db = new ProductDataAccess();
            var Categorias = categoryBox4.SelectedItems;
            List<CategoriaProducto> categoriasSeleccionadas = new List<CategoriaProducto>();
            foreach (var categoria in Categorias)
            {
                var categoriaSeleccionada = (CategoriaProducto)Enum.Parse(typeof(CategoriaProducto), categoria.ToString());
                categoriasSeleccionadas.Add(categoriaSeleccionada);
            }


            var producto = new ProductModel
            {
                Id = model.Id,
                Name = nombre,
                Description = description,
                Price = price,
                Categorias = categoriasSeleccionadas,
            };


            try
            {
                await db.UpdateProduct(producto);
                MessageBox.Show($"Se ha actualizado el producto");
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error al actualizar el producto");
            }
        }



    }
}
