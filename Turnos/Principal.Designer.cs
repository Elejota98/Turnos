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
            this.pnTitulo = new System.Windows.Forms.Panel();
            this.TabPrincipal = new System.Windows.Forms.TabControl();
            this.Menu = new System.Windows.Forms.TabPage();
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.Asistencia = new System.Windows.Forms.TabPage();
            this.Empleados = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCargo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSede = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TabPrincipal.SuspendLayout();
            this.Menu.SuspendLayout();
            this.Empleados.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTitulo
            // 
            this.pnTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnTitulo.Name = "pnTitulo";
            this.pnTitulo.Size = new System.Drawing.Size(1430, 139);
            this.pnTitulo.TabIndex = 2;
            // 
            // TabPrincipal
            // 
            this.TabPrincipal.Controls.Add(this.Menu);
            this.TabPrincipal.Controls.Add(this.Asistencia);
            this.TabPrincipal.Controls.Add(this.Empleados);
            this.TabPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabPrincipal.Location = new System.Drawing.Point(0, 139);
            this.TabPrincipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabPrincipal.Name = "TabPrincipal";
            this.TabPrincipal.SelectedIndex = 0;
            this.TabPrincipal.Size = new System.Drawing.Size(1430, 981);
            this.TabPrincipal.TabIndex = 6;
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.btnAsistencia);
            this.Menu.Controls.Add(this.btnEmpleados);
            this.Menu.Location = new System.Drawing.Point(4, 25);
            this.Menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Menu.Size = new System.Drawing.Size(1422, 952);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "tabMenu";
            this.Menu.UseVisualStyleBackColor = true;
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.Location = new System.Drawing.Point(415, 310);
            this.btnAsistencia.Margin = new System.Windows.Forms.Padding(4);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Size = new System.Drawing.Size(100, 28);
            this.btnAsistencia.TabIndex = 1;
            this.btnAsistencia.Text = "Asistencia";
            this.btnAsistencia.UseVisualStyleBackColor = true;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Location = new System.Drawing.Point(472, 201);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(100, 28);
            this.btnEmpleados.TabIndex = 0;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // Asistencia
            // 
            this.Asistencia.Location = new System.Drawing.Point(4, 25);
            this.Asistencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Asistencia.Name = "Asistencia";
            this.Asistencia.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Asistencia.Size = new System.Drawing.Size(1422, 952);
            this.Asistencia.TabIndex = 1;
            this.Asistencia.Text = "tabAsistencia";
            this.Asistencia.UseVisualStyleBackColor = true;
            // 
            // Empleados
            // 
            this.Empleados.Controls.Add(this.panel1);
            this.Empleados.Font = new System.Drawing.Font("Ford Antenna XCnd", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.Empleados.Location = new System.Drawing.Point(4, 25);
            this.Empleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Empleados.Name = "Empleados";
            this.Empleados.Size = new System.Drawing.Size(1422, 952);
            this.Empleados.TabIndex = 2;
            this.Empleados.Text = "Empleados";
            this.Empleados.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.txtDocumento);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtApellidos);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cboCargo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboSede);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1422, 952);
            this.panel1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ford Antenna XCnd", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.label5.Location = new System.Drawing.Point(406, 471);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 38);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cargo";
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = global::Turnos.Properties.Resources.btnGuardar;
            this.btnGuardar.Location = new System.Drawing.Point(389, 700);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(141, 59);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Font = new System.Drawing.Font("Ford Antenna XCnd", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(551, 130);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(188, 38);
            this.txtDocumento.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 570);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 38);
            this.label6.TabIndex = 13;
            this.label6.Text = "Sede";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Ford Antenna XCnd", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(551, 210);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(188, 38);
            this.txtNombre.TabIndex = 2;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Ford Antenna XCnd", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(551, 293);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(188, 38);
            this.txtApellidos.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ford Antenna XCnd", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.label4.Location = new System.Drawing.Point(382, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 38);
            this.label4.TabIndex = 11;
            this.label4.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Ford Antenna XCnd", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(551, 380);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(188, 38);
            this.txtTelefono.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ford Antenna XCnd", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.label3.Location = new System.Drawing.Point(377, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 38);
            this.label3.TabIndex = 10;
            this.label3.Text = "Apellidos";
            // 
            // cboCargo
            // 
            this.cboCargo.Font = new System.Drawing.Font("Ford Antenna XCnd", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Location = new System.Drawing.Point(543, 470);
            this.cboCargo.Margin = new System.Windows.Forms.Padding(4);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(240, 38);
            this.cboCargo.TabIndex = 5;
            this.cboCargo.Text = "Seleccione...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ford Antenna XCnd", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(372, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 38);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombres";
            // 
            // cboSede
            // 
            this.cboSede.Font = new System.Drawing.Font("Ford Antenna XCnd", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSede.FormattingEnabled = true;
            this.cboSede.Location = new System.Drawing.Point(542, 562);
            this.cboSede.Margin = new System.Windows.Forms.Padding(4);
            this.cboSede.Name = "cboSede";
            this.cboSede.Size = new System.Drawing.Size(241, 38);
            this.cboSede.TabIndex = 6;
            this.cboSede.Text = "Seleccione...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ford Antenna XCnd", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(348, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "Documento";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 1036);
            this.Controls.Add(this.TabPrincipal);
            this.Controls.Add(this.pnTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio - TurnosApp";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.TabPrincipal.ResumeLayout(false);
            this.Menu.ResumeLayout(false);
            this.Empleados.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnTitulo;
        private System.Windows.Forms.TabControl TabPrincipal;
        private System.Windows.Forms.TabPage Menu;
        private System.Windows.Forms.TabPage Asistencia;
        private System.Windows.Forms.TabPage Empleados;
        private System.Windows.Forms.ComboBox cboSede;
        private System.Windows.Forms.ComboBox cboCargo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Button btnAsistencia;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel1;
    }
}

