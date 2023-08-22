namespace Turnos
{
    partial class Principal
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pnTitulo = new System.Windows.Forms.Panel();
            this.TabPrincipal = new System.Windows.Forms.TabControl();
            this.Menu = new System.Windows.Forms.TabPage();
            this.Asistencia = new System.Windows.Forms.TabPage();
            this.TurnosAplicados = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.TabPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 178);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(51, 670);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 60);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(345, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 178);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(112, 334);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 178);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(600, 111);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(192, 178);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(345, 334);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(192, 178);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(600, 334);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(192, 178);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // pnTitulo
            // 
            this.pnTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnTitulo.Name = "pnTitulo";
            this.pnTitulo.Size = new System.Drawing.Size(1024, 89);
            this.pnTitulo.TabIndex = 2;
            // 
            // TabPrincipal
            // 
            this.TabPrincipal.Controls.Add(this.Menu);
            this.TabPrincipal.Controls.Add(this.Asistencia);
            this.TabPrincipal.Controls.Add(this.TurnosAplicados);
            this.TabPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabPrincipal.Location = new System.Drawing.Point(0, 111);
            this.TabPrincipal.Name = "TabPrincipal";
            this.TabPrincipal.SelectedIndex = 0;
            this.TabPrincipal.Size = new System.Drawing.Size(1280, 849);
            this.TabPrincipal.TabIndex = 6;
            // 
            // Menu
            // 
            this.Menu.Location = new System.Drawing.Point(4, 25);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(3);
            this.Menu.Size = new System.Drawing.Size(1272, 820);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "tabMenu";
            this.Menu.UseVisualStyleBackColor = true;
            // 
            // Asistencia
            // 
            this.Asistencia.Location = new System.Drawing.Point(4, 25);
            this.Asistencia.Name = "Asistencia";
            this.Asistencia.Padding = new System.Windows.Forms.Padding(3);
            this.Asistencia.Size = new System.Drawing.Size(1272, 820);
            this.Asistencia.TabIndex = 1;
            this.Asistencia.Text = "tabAsistencia";
            this.Asistencia.UseVisualStyleBackColor = true;
            // 
            // TurnosAplicados
            // 
            this.TurnosAplicados.Location = new System.Drawing.Point(4, 25);
            this.TurnosAplicados.Name = "TurnosAplicados";
            this.TurnosAplicados.Size = new System.Drawing.Size(1272, 820);
            this.TurnosAplicados.TabIndex = 2;
            this.TurnosAplicados.Text = "tabTurnosAplicados";
            this.TurnosAplicados.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.TabPrincipal);
            this.Controls.Add(this.pnTitulo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio - TurnosApp";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panel1.ResumeLayout(false);
            this.TabPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnTitulo;
        private System.Windows.Forms.TabControl TabPrincipal;
        private System.Windows.Forms.TabPage Menu;
        private System.Windows.Forms.TabPage Asistencia;
        private System.Windows.Forms.TabPage TurnosAplicados;
    }
}

