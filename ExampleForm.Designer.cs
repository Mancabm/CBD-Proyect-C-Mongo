namespace C_Mongo
{
    partial class ExampleForm
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
            this.helloButton = new System.Windows.Forms.Button();
            this.printLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // helloButton
            // 
            this.helloButton.Location = new System.Drawing.Point(64, 40);
            this.helloButton.Name = "helloButton";
            this.helloButton.Size = new System.Drawing.Size(146, 23);
            this.helloButton.TabIndex = 0;
            this.helloButton.Text = "Print Hello World";
            this.helloButton.UseVisualStyleBackColor = true;
            this.helloButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // printLabel
            // 
            this.printLabel.AutoSize = true;
            this.printLabel.Location = new System.Drawing.Point(234, 40);
            this.printLabel.Name = "printLabel";
            this.printLabel.Size = new System.Drawing.Size(44, 16);
            this.printLabel.TabIndex = 1;
            this.printLabel.Text = "label1";
            // 
            // ExampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.printLabel);
            this.Controls.Add(this.helloButton);
            this.Name = "ExampleForm";
            this.Text = "ExampleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button helloButton;
        private System.Windows.Forms.Label printLabel;
    }
}