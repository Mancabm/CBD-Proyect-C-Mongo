using C_Mongo.Models;
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
            //categoryBox4.SelectedItems.Add(model.Categorias.Select(c => c.ToString()).ToArray());
        }

       
    }
}
