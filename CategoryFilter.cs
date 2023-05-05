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
    public partial class CategoryFilter : Form
    {
        public CategoryFilter()
        {
            InitializeComponent();
        }
        private void filterButton_clicked(object sender, EventArgs e)
        {
            string category = categoryBox.SelectedItem.ToString();
            ListaProductos listaProductos = new ListaProductos(category);
            listaProductos.Show();
        }
    }
}
