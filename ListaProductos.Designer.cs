namespace C_Mongo
{
    partial class ListaProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listadoProductos = new System.Windows.Forms.DataGridView();
            this.productModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listadoProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productModelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listadoProductos
            // 
            this.listadoProductos.AllowUserToAddRows = false;
            this.listadoProductos.AllowUserToDeleteRows = false;
            this.listadoProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Description,
            this.Price,
            this.Categories,
            this.Update,
            this.Delete});
            this.listadoProductos.Location = new System.Drawing.Point(64, 27);
            this.listadoProductos.Margin = new System.Windows.Forms.Padding(4);
            this.listadoProductos.Name = "listadoProductos";
            this.listadoProductos.ReadOnly = true;
            this.listadoProductos.RowHeadersWidth = 51;
            this.listadoProductos.Size = new System.Drawing.Size(960, 478);
            this.listadoProductos.TabIndex = 0;
            // 
            // productModelBindingSource1
            // 
            this.productModelBindingSource1.DataSource = typeof(C_Mongo.Models.ProductModel);
            // 
            // productModelBindingSource
            // 
            this.productModelBindingSource.DataSource = typeof(C_Mongo.Models.ProductModel);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 125;
            // 
            // Categories
            // 
            this.Categories.HeaderText = "Categories";
            this.Categories.MinimumWidth = 6;
            this.Categories.Name = "Categories";
            this.Categories.ReadOnly = true;
            this.Categories.Width = 125;
            // 
            // Update
            // 
            this.Update.HeaderText = "Update";
            this.Update.MinimumWidth = 6;
            this.Update.Name = "Update";
            this.Update.ReadOnly = true;
            this.Update.Width = 90;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 91;
            // 
            // ListaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.listadoProductos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListaProductos";
            this.Text = "ListaProductos";
            ((System.ComponentModel.ISupportInitialize)(this.listadoProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productModelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listadoProductos;
        private System.Windows.Forms.BindingSource productModelBindingSource;
        private System.Windows.Forms.BindingSource productModelBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categories;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}