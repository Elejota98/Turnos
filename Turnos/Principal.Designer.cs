﻿namespace Turnos
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.TabPrincipal = new System.Windows.Forms.TabControl();
            this.Menu = new System.Windows.Forms.TabPage();
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.Asistencia = new System.Windows.Forms.TabPage();
            this.pnAsistencia = new System.Windows.Forms.Panel();
            this.btnRegistrarSalida = new System.Windows.Forms.Button();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.Empleados = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dvgListadoEmpleados = new System.Windows.Forms.DataGridView();
            this.txtDocumentoBuscar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
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
            this.ActualizarDatosEmpleado = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbActDocumento = new System.Windows.Forms.TextBox();
            this.tbActNombres = new System.Windows.Forms.TextBox();
            this.tbActApellidos = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbActTelefono = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboActCargo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbActSede = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pnTitulo.SuspendLayout();
            this.TabPrincipal.SuspendLayout();
            this.Menu.SuspendLayout();
            this.Asistencia.SuspendLayout();
            this.pnAsistencia.SuspendLayout();
            this.Empleados.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgListadoEmpleados)).BeginInit();
            this.ActualizarDatosEmpleado.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTitulo
            // 
            this.pnTitulo.Controls.Add(this.lblTitulo);
            this.pnTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.pnTitulo.Name = "pnTitulo";
            this.pnTitulo.Size = new System.Drawing.Size(1009, 88);
            this.pnTitulo.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblTitulo.Location = new System.Drawing.Point(702, 24);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(0, 39);
            this.lblTitulo.TabIndex = 0;
            // 
            // TabPrincipal
            // 
            this.TabPrincipal.Controls.Add(this.Menu);
            this.TabPrincipal.Controls.Add(this.Asistencia);
            this.TabPrincipal.Controls.Add(this.Empleados);
            this.TabPrincipal.Controls.Add(this.ActualizarDatosEmpleado);
            this.TabPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabPrincipal.Location = new System.Drawing.Point(0, 88);
            this.TabPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.TabPrincipal.Name = "TabPrincipal";
            this.TabPrincipal.SelectedIndex = 0;
            this.TabPrincipal.Size = new System.Drawing.Size(1009, 1319);
            this.TabPrincipal.TabIndex = 6;
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.btnAsistencia);
            this.Menu.Controls.Add(this.btnEmpleados);
            this.Menu.Location = new System.Drawing.Point(4, 22);
            this.Menu.Margin = new System.Windows.Forms.Padding(2);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(2);
            this.Menu.Size = new System.Drawing.Size(1001, 1293);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "tabMenu";
            this.Menu.UseVisualStyleBackColor = true;
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.Location = new System.Drawing.Point(311, 252);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Size = new System.Drawing.Size(75, 23);
            this.btnAsistencia.TabIndex = 1;
            this.btnAsistencia.Text = "Asistencia";
            this.btnAsistencia.UseVisualStyleBackColor = true;
            this.btnAsistencia.Click += new System.EventHandler(this.btnAsistencia_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Location = new System.Drawing.Point(354, 163);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(75, 23);
            this.btnEmpleados.TabIndex = 0;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // Asistencia
            // 
            this.Asistencia.Controls.Add(this.pnAsistencia);
            this.Asistencia.Location = new System.Drawing.Point(4, 22);
            this.Asistencia.Margin = new System.Windows.Forms.Padding(2);
            this.Asistencia.Name = "Asistencia";
            this.Asistencia.Padding = new System.Windows.Forms.Padding(2);
            this.Asistencia.Size = new System.Drawing.Size(1001, 1293);
            this.Asistencia.TabIndex = 1;
            this.Asistencia.Text = "tabAsistencia";
            this.Asistencia.UseVisualStyleBackColor = true;
            // 
            // pnAsistencia
            // 
            this.pnAsistencia.Controls.Add(this.btnRegistrarSalida);
            this.pnAsistencia.Controls.Add(this.btnIngreso);
            this.pnAsistencia.Location = new System.Drawing.Point(2, 4);
            this.pnAsistencia.Margin = new System.Windows.Forms.Padding(2);
            this.pnAsistencia.Name = "pnAsistencia";
            this.pnAsistencia.Size = new System.Drawing.Size(1000, 589);
            this.pnAsistencia.TabIndex = 0;
            // 
            // btnRegistrarSalida
            // 
            this.btnRegistrarSalida.Location = new System.Drawing.Point(416, 199);
            this.btnRegistrarSalida.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarSalida.Name = "btnRegistrarSalida";
            this.btnRegistrarSalida.Size = new System.Drawing.Size(56, 44);
            this.btnRegistrarSalida.TabIndex = 1;
            this.btnRegistrarSalida.Text = "Registrar salida";
            this.btnRegistrarSalida.UseVisualStyleBackColor = true;
            this.btnRegistrarSalida.Click += new System.EventHandler(this.btnRegistrarSalida_Click);
            // 
            // btnIngreso
            // 
            this.btnIngreso.Location = new System.Drawing.Point(174, 199);
            this.btnIngreso.Margin = new System.Windows.Forms.Padding(2);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(56, 44);
            this.btnIngreso.TabIndex = 0;
            this.btnIngreso.Text = "Registrar Ingreso";
            this.btnIngreso.UseVisualStyleBackColor = true;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // Empleados
            // 
            this.Empleados.Controls.Add(this.panel1);
            this.Empleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.Empleados.Location = new System.Drawing.Point(4, 22);
            this.Empleados.Margin = new System.Windows.Forms.Padding(2);
            this.Empleados.Name = "Empleados";
            this.Empleados.Size = new System.Drawing.Size(1001, 1293);
            this.Empleados.TabIndex = 2;
            this.Empleados.Text = "tbEmpleados";
            this.Empleados.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dvgListadoEmpleados);
            this.panel1.Controls.Add(this.txtDocumentoBuscar);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.button2);
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
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 589);
            this.panel1.TabIndex = 15;
            // 
            // dvgListadoEmpleados
            // 
            this.dvgListadoEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgListadoEmpleados.Location = new System.Drawing.Point(304, 50);
            this.dvgListadoEmpleados.Margin = new System.Windows.Forms.Padding(2);
            this.dvgListadoEmpleados.Name = "dvgListadoEmpleados";
            this.dvgListadoEmpleados.RowHeadersWidth = 51;
            this.dvgListadoEmpleados.RowTemplate.Height = 24;
            this.dvgListadoEmpleados.Size = new System.Drawing.Size(692, 294);
            this.dvgListadoEmpleados.TabIndex = 21;
            // 
            // txtDocumentoBuscar
            // 
            this.txtDocumentoBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumentoBuscar.Location = new System.Drawing.Point(619, 16);
            this.txtDocumentoBuscar.Name = "txtDocumentoBuscar";
            this.txtDocumentoBuscar.Size = new System.Drawing.Size(135, 28);
            this.txtDocumentoBuscar.TabIndex = 19;
            this.txtDocumentoBuscar.TextChanged += new System.EventHandler(this.txtDocumentoBuscar_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.label13.Location = new System.Drawing.Point(538, 19);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 24);
            this.label13.TabIndex = 20;
            this.label13.Text = "Documento";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Turnos.Properties.Resources.btnActualizar;
            this.button2.Location = new System.Drawing.Point(413, 502);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 50);
            this.button2.TabIndex = 17;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.label5.Location = new System.Drawing.Point(56, 318);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cargo";
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = global::Turnos.Properties.Resources.btnGuardar;
            this.btnGuardar.Location = new System.Drawing.Point(285, 502);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 50);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtDocumento
            // 
            this.txtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(118, 32);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(143, 28);
            this.txtDocumento.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 399);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Sede";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(118, 97);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(143, 28);
            this.txtNombre.TabIndex = 2;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(118, 164);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(143, 28);
            this.txtApellidos.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.label4.Location = new System.Drawing.Point(38, 247);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(118, 235);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(143, 28);
            this.txtTelefono.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.label3.Location = new System.Drawing.Point(34, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Apellidos";
            // 
            // cboCargo
            // 
            this.cboCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Location = new System.Drawing.Point(119, 316);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(181, 30);
            this.cboCargo.TabIndex = 5;
            this.cboCargo.Text = "Seleccione...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(30, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombres";
            // 
            // cboSede
            // 
            this.cboSede.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSede.FormattingEnabled = true;
            this.cboSede.Location = new System.Drawing.Point(118, 399);
            this.cboSede.Name = "cboSede";
            this.cboSede.Size = new System.Drawing.Size(182, 30);
            this.cboSede.TabIndex = 6;
            this.cboSede.Text = "Seleccione...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Documento";
            // 
            // ActualizarDatosEmpleado
            // 
            this.ActualizarDatosEmpleado.Controls.Add(this.panel2);
            this.ActualizarDatosEmpleado.Location = new System.Drawing.Point(4, 22);
            this.ActualizarDatosEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.ActualizarDatosEmpleado.Name = "ActualizarDatosEmpleado";
            this.ActualizarDatosEmpleado.Size = new System.Drawing.Size(1001, 1293);
            this.ActualizarDatosEmpleado.TabIndex = 3;
            this.ActualizarDatosEmpleado.Text = "tbActualizarDatosEmpleados";
            this.ActualizarDatosEmpleado.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.tbActDocumento);
            this.panel2.Controls.Add(this.tbActNombres);
            this.panel2.Controls.Add(this.tbActApellidos);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.tbActTelefono);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.cboActCargo);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.cbActSede);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1001, 1293);
            this.panel2.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.label8.Location = new System.Drawing.Point(304, 454);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 31);
            this.label8.TabIndex = 15;
            this.label8.Text = "Sede";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.label7.Location = new System.Drawing.Point(304, 383);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 31);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cargo";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Turnos.Properties.Resources.btnGuardar;
            this.button1.Location = new System.Drawing.Point(321, 567);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 42);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbActDocumento
            // 
            this.tbActDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbActDocumento.Location = new System.Drawing.Point(413, 106);
            this.tbActDocumento.Name = "tbActDocumento";
            this.tbActDocumento.Size = new System.Drawing.Size(177, 31);
            this.tbActDocumento.TabIndex = 1;
            // 
            // tbActNombres
            // 
            this.tbActNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbActNombres.Location = new System.Drawing.Point(413, 171);
            this.tbActNombres.Name = "tbActNombres";
            this.tbActNombres.Size = new System.Drawing.Size(177, 31);
            this.tbActNombres.TabIndex = 2;
            // 
            // tbActApellidos
            // 
            this.tbActApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbActApellidos.Location = new System.Drawing.Point(413, 238);
            this.tbActApellidos.Name = "tbActApellidos";
            this.tbActApellidos.Size = new System.Drawing.Size(177, 31);
            this.tbActApellidos.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.label9.Location = new System.Drawing.Point(286, 311);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 31);
            this.label9.TabIndex = 11;
            this.label9.Text = "Teléfono";
            // 
            // tbActTelefono
            // 
            this.tbActTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbActTelefono.Location = new System.Drawing.Point(413, 309);
            this.tbActTelefono.Name = "tbActTelefono";
            this.tbActTelefono.Size = new System.Drawing.Size(177, 31);
            this.tbActTelefono.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.label10.Location = new System.Drawing.Point(283, 242);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 31);
            this.label10.TabIndex = 10;
            this.label10.Text = "Apellidos";
            // 
            // cboActCargo
            // 
            this.cboActCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboActCargo.FormattingEnabled = true;
            this.cboActCargo.Location = new System.Drawing.Point(407, 382);
            this.cboActCargo.Name = "cboActCargo";
            this.cboActCargo.Size = new System.Drawing.Size(181, 33);
            this.cboActCargo.TabIndex = 5;
            this.cboActCargo.Text = "Seleccione...";
            this.cboActCargo.SelectedIndexChanged += new System.EventHandler(this.cboActCargo_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.label11.Location = new System.Drawing.Point(279, 169);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 31);
            this.label11.TabIndex = 9;
            this.label11.Text = "Nombres";
            // 
            // cbActSede
            // 
            this.cbActSede.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbActSede.FormattingEnabled = true;
            this.cbActSede.Location = new System.Drawing.Point(406, 457);
            this.cbActSede.Name = "cbActSede";
            this.cbActSede.Size = new System.Drawing.Size(182, 33);
            this.cbActSede.TabIndex = 6;
            this.cbActSede.Text = "Seleccione...";
            this.cbActSede.SelectedIndexChanged += new System.EventHandler(this.cbActSede_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.label12.Location = new System.Drawing.Point(261, 101);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 31);
            this.label12.TabIndex = 8;
            this.label12.Text = "Documento";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 727);
            this.Controls.Add(this.TabPrincipal);
            this.Controls.Add(this.pnTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio - TurnosApp";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.pnTitulo.ResumeLayout(false);
            this.pnTitulo.PerformLayout();
            this.TabPrincipal.ResumeLayout(false);
            this.Menu.ResumeLayout(false);
            this.Asistencia.ResumeLayout(false);
            this.pnAsistencia.ResumeLayout(false);
            this.Empleados.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgListadoEmpleados)).EndInit();
            this.ActualizarDatosEmpleado.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.TabPage ActualizarDatosEmpleado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbActDocumento;
        private System.Windows.Forms.TextBox tbActNombres;
        private System.Windows.Forms.TextBox tbActApellidos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbActTelefono;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboActCargo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbActSede;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtDocumentoBuscar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dvgListadoEmpleados;
        private System.Windows.Forms.Panel pnAsistencia;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnRegistrarSalida;
    }
}

