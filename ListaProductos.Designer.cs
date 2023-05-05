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
            this.listadoProductos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.listadoProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // listadoProductos
            // 
            this.listadoProductos.AllowUserToAddRows = false;
            this.listadoProductos.AllowUserToDeleteRows = false;
            this.listadoProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoProductos.Location = new System.Drawing.Point(48, 22);
            this.listadoProductos.Name = "listadoProductos";
            this.listadoProductos.ReadOnly = true;
            this.listadoProductos.Size = new System.Drawing.Size(720, 388);
            this.listadoProductos.TabIndex = 0;
            // 
            // ListaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listadoProductos);
            this.Name = "ListaProductos";
            this.Text = "ListaProductos";
            ((System.ComponentModel.ISupportInitialize)(this.listadoProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listadoProductos;
    }
}