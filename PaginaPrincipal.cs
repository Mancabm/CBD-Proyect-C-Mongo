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
    public partial class PaginaPrincipal : Form
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCreateProduct cp = new FormCreateProduct();
            cp.Show();

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ListaProductos cp = new ListaProductos();
            cp.Show();
        }

        private void categoryLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CategoryFilter categoryFilter = new CategoryFilter();
            categoryFilter.Show();

        }
    }
}
