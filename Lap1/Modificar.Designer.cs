namespace Lap1
{
    partial class Modificar
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
            this.enviarButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cedulatxt = new System.Windows.Forms.TextBox();
            this.Apellidotxt = new System.Windows.Forms.TextBox();
            this.Salariotxt = new System.Windows.Forms.TextBox();
            this.Nombretxt = new System.Windows.Forms.TextBox();
            this.buscarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enviarButton
            // 
            this.enviarButton.Location = new System.Drawing.Point(323, 303);
            this.enviarButton.Name = "enviarButton";
            this.enviarButton.Size = new System.Drawing.Size(173, 50);
            this.enviarButton.TabIndex = 18;
            this.enviarButton.Text = "Enviar";
            this.enviarButton.UseVisualStyleBackColor = true;
            this.enviarButton.Click += new System.EventHandler(this.enviarButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(544, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Salario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(544, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cedula";
            // 
            // Cedulatxt
            // 
            this.Cedulatxt.Location = new System.Drawing.Point(117, 120);
            this.Cedulatxt.Name = "Cedulatxt";
            this.Cedulatxt.Size = new System.Drawing.Size(139, 26);
            this.Cedulatxt.TabIndex = 13;
            // 
            // Apellidotxt
            // 
            this.Apellidotxt.Location = new System.Drawing.Point(548, 214);
            this.Apellidotxt.Name = "Apellidotxt";
            this.Apellidotxt.Size = new System.Drawing.Size(139, 26);
            this.Apellidotxt.TabIndex = 12;
            // 
            // Salariotxt
            // 
            this.Salariotxt.Location = new System.Drawing.Point(117, 214);
            this.Salariotxt.Name = "Salariotxt";
            this.Salariotxt.Size = new System.Drawing.Size(139, 26);
            this.Salariotxt.TabIndex = 11;
            // 
            // Nombretxt
            // 
            this.Nombretxt.Location = new System.Drawing.Point(548, 120);
            this.Nombretxt.Name = "Nombretxt";
            this.Nombretxt.Size = new System.Drawing.Size(139, 26);
            this.Nombretxt.TabIndex = 10;
            // 
            // buscarButton
            // 
            this.buscarButton.Location = new System.Drawing.Point(262, 109);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(107, 49);
            this.buscarButton.TabIndex = 19;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            // 
            // Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.enviarButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cedulatxt);
            this.Controls.Add(this.Apellidotxt);
            this.Controls.Add(this.Salariotxt);
            this.Controls.Add(this.Nombretxt);
            this.Name = "Modificar";
            this.Text = "Modificar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enviarButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Cedulatxt;
        private System.Windows.Forms.TextBox Apellidotxt;
        private System.Windows.Forms.TextBox Salariotxt;
        private System.Windows.Forms.TextBox Nombretxt;
        private System.Windows.Forms.Button buscarButton;
    }
}