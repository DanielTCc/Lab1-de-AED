namespace Lap1
{
    partial class Ingresar
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
            this.Nombretxt = new System.Windows.Forms.TextBox();
            this.Salariotxt = new System.Windows.Forms.TextBox();
            this.Apellidotxt = new System.Windows.Forms.TextBox();
            this.Cedulatxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.enviarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nombretxt
            // 
            this.Nombretxt.Location = new System.Drawing.Point(499, 143);
            this.Nombretxt.Name = "Nombretxt";
            this.Nombretxt.Size = new System.Drawing.Size(139, 26);
            this.Nombretxt.TabIndex = 0;
            // 
            // Salariotxt
            // 
            this.Salariotxt.Location = new System.Drawing.Point(68, 237);
            this.Salariotxt.Name = "Salariotxt";
            this.Salariotxt.Size = new System.Drawing.Size(139, 26);
            this.Salariotxt.TabIndex = 2;
            // 
            // Apellidotxt
            // 
            this.Apellidotxt.Location = new System.Drawing.Point(499, 237);
            this.Apellidotxt.Name = "Apellidotxt";
            this.Apellidotxt.Size = new System.Drawing.Size(139, 26);
            this.Apellidotxt.TabIndex = 3;
            // 
            // Cedulatxt
            // 
            this.Cedulatxt.Location = new System.Drawing.Point(68, 143);
            this.Cedulatxt.Name = "Cedulatxt";
            this.Cedulatxt.Size = new System.Drawing.Size(139, 26);
            this.Cedulatxt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cedula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(495, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Salario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(495, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Apellido";
            // 
            // enviarButton
            // 
            this.enviarButton.Location = new System.Drawing.Point(274, 326);
            this.enviarButton.Name = "enviarButton";
            this.enviarButton.Size = new System.Drawing.Size(173, 50);
            this.enviarButton.TabIndex = 9;
            this.enviarButton.Text = "Enviar";
            this.enviarButton.UseVisualStyleBackColor = true;
            this.enviarButton.Click += new System.EventHandler(this.enviarButton_Click);
            // 
            // Ingresar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.enviarButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cedulatxt);
            this.Controls.Add(this.Apellidotxt);
            this.Controls.Add(this.Salariotxt);
            this.Controls.Add(this.Nombretxt);
            this.Name = "Ingresar";
            this.Text = "Ingresar";
            this.Load += new System.EventHandler(this.Ingresar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nombretxt;
        private System.Windows.Forms.TextBox Salariotxt;
        private System.Windows.Forms.TextBox Apellidotxt;
        private System.Windows.Forms.TextBox Cedulatxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button enviarButton;
    }
}