namespace Lap1
{
    partial class Imprimir
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
            this.ImpresoraDTG = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.ActualizarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImpresoraDTG)).BeginInit();
            this.SuspendLayout();
            // 
            // ImpresoraDTG
            // 
            this.ImpresoraDTG.AllowUserToOrderColumns = true;
            this.ImpresoraDTG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ImpresoraDTG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.ImpresoraDTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ImpresoraDTG.Location = new System.Drawing.Point(1, 170);
            this.ImpresoraDTG.Name = "ImpresoraDTG";
            this.ImpresoraDTG.RowHeadersWidth = 62;
            this.ImpresoraDTG.RowTemplate.Height = 28;
            this.ImpresoraDTG.Size = new System.Drawing.Size(799, 280);
            this.ImpresoraDTG.TabIndex = 0;
            this.ImpresoraDTG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ImpresoraDTG_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 26);
            this.textBox1.TabIndex = 1;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(12, 44);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(124, 35);
            this.BuscarButton.TabIndex = 2;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // ActualizarButton
            // 
            this.ActualizarButton.Location = new System.Drawing.Point(12, 85);
            this.ActualizarButton.Name = "ActualizarButton";
            this.ActualizarButton.Size = new System.Drawing.Size(124, 35);
            this.ActualizarButton.TabIndex = 3;
            this.ActualizarButton.Text = "Actualizar";
            this.ActualizarButton.UseVisualStyleBackColor = true;
            this.ActualizarButton.Click += new System.EventHandler(this.ActualizarButton_Click);
            // 
            // Imprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ActualizarButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ImpresoraDTG);
            this.Name = "Imprimir";
            this.Text = "Imprimir";
            this.Load += new System.EventHandler(this.Imprimir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImpresoraDTG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ImpresoraDTG;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button ActualizarButton;
    }
}