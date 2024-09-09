namespace Lap1
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ingresarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirGestioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarEmpleadoToolStripMenuItem,
            this.imprimirGestioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ingresarEmpleadoToolStripMenuItem
            // 
            this.ingresarEmpleadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mToolStripMenuItem,
            this.modificarEmpleadoToolStripMenuItem,
            this.eliminarEmpleadoToolStripMenuItem});
            this.ingresarEmpleadoToolStripMenuItem.Name = "ingresarEmpleadoToolStripMenuItem";
            this.ingresarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(174, 32);
            this.ingresarEmpleadoToolStripMenuItem.Text = "Geation Empleado";
            this.ingresarEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.ingresarEmpleadoToolStripMenuItem_Click);
            // 
            // mToolStripMenuItem
            // 
            this.mToolStripMenuItem.Name = "mToolStripMenuItem";
            this.mToolStripMenuItem.Size = new System.Drawing.Size(320, 34);
            this.mToolStripMenuItem.Text = "Ingresar Nuevo Empleado";
            this.mToolStripMenuItem.Click += new System.EventHandler(this.mToolStripMenuItem_Click);
            // 
            // modificarEmpleadoToolStripMenuItem
            // 
            this.modificarEmpleadoToolStripMenuItem.Name = "modificarEmpleadoToolStripMenuItem";
            this.modificarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(320, 34);
            this.modificarEmpleadoToolStripMenuItem.Text = "Modificar Empleado";
            this.modificarEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.modificarEmpleadoToolStripMenuItem_Click);
            // 
            // eliminarEmpleadoToolStripMenuItem
            // 
            this.eliminarEmpleadoToolStripMenuItem.Name = "eliminarEmpleadoToolStripMenuItem";
            this.eliminarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(320, 34);
            this.eliminarEmpleadoToolStripMenuItem.Text = "Eliminar Empleado";
            this.eliminarEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.eliminarEmpleadoToolStripMenuItem_Click);
            // 
            // imprimirGestioToolStripMenuItem
            // 
            this.imprimirGestioToolStripMenuItem.Name = "imprimirGestioToolStripMenuItem";
            this.imprimirGestioToolStripMenuItem.Size = new System.Drawing.Size(161, 32);
            this.imprimirGestioToolStripMenuItem.Text = "Imprimir Gestion";
            this.imprimirGestioToolStripMenuItem.Click += new System.EventHandler(this.imprimirGestioToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "Gestion";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ingresarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirGestioToolStripMenuItem;
    }
}

