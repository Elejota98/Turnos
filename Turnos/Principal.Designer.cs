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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnTitulo = new System.Windows.Forms.Panel();
            this.TabPrincipal = new System.Windows.Forms.TabControl();
            this.Menu = new System.Windows.Forms.TabPage();
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.Asistencia = new System.Windows.Forms.TabPage();
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
            this.pnAsistencia = new System.Windows.Forms.Panel();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnTitulo.SuspendLayout();
            this.TabPrincipal.SuspendLayout();
            this.Menu.SuspendLayout();
            this.Asistencia.SuspendLayout();
            this.Empleados.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgListadoEmpleados)).BeginInit();
            this.ActualizarDatosEmpleado.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnAsistencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTitulo
            // 
            this.pnTitulo.Controls.Add(this.lblTitulo);
            this.pnTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnTitulo.Name = "pnTitulo";
            this.pnTitulo.Size = new System.Drawing.Size(1345, 108);
            this.pnTitulo.TabIndex = 2;
            // 
            // TabPrincipal
            // 
            this.TabPrincipal.Controls.Add(this.Menu);
            this.TabPrincipal.Controls.Add(this.Asistencia);
            this.TabPrincipal.Controls.Add(this.Empleados);
            this.TabPrincipal.Controls.Add(this.ActualizarDatosEmpleado);
            this.TabPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabPrincipal.Location = new System.Drawing.Point(0, 108);
            this.TabPrincipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabPrincipal.Name = "TabPrincipal";
            this.TabPrincipal.SelectedIndex = 0;
            this.TabPrincipal.Size = new System.Drawing.Size(1345, 1623);
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
            this.Menu.Size = new System.Drawing.Size(1337, 1594);
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
            this.btnAsistencia.Click += new System.EventHandler(this.btnAsistencia_Click);
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
            this.Asistencia.Controls.Add(this.pnAsistencia);
            this.Asistencia.Location = new System.Drawing.Point(4, 25);
            this.Asistencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Asistencia.Name = "Asistencia";
            this.Asistencia.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Asistencia.Size = new System.Drawing.Size(1337, 1594);
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
            this.Empleados.Size = new System.Drawing.Size(1337, 1594);
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1341, 725);
            this.panel1.TabIndex = 15;
            // 
            // dvgListadoEmpleados
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Ford Antenna XCnd", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgListadoEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dvgListadoEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Ford Antenna XCnd", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgListadoEmpleados.DefaultCellStyle = dataGridViewCellStyle8;
            this.dvgListadoEmpleados.Location = new System.Drawing.Point(406, 61);
            this.dvgListadoEmpleados.Name = "dvgListadoEmpleados";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Ford Antenna XCnd", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgListadoEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dvgListadoEmpleados.RowHeadersWidth = 51;
            this.dvgListadoEmpleados.RowTemplate.Height = 24;
            this.dvgListadoEmpleados.Size = new System.Drawing.Size(923, 362);
            this.dvgListadoEmpleados.TabIndex = 21;
            // 
            // txtDocumentoBuscar
            // 
            this.txtDocumentoBuscar.Font = new System.Drawing.Font("Ford Antenna XCnd", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumentoBuscar.Location = new System.Drawing.Point(825, 20);
            this.txtDocumentoBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtDocumentoBuscar.Name = "txtDocumentoBuscar";
            this.txtDocumentoBuscar.Size = new System.Drawing.Size(179, 34);
            this.txtDocumentoBuscar.TabIndex = 19;
            this.txtDocumentoBuscar.TextChanged += new System.EventHandler(this.txtDocumentoBuscar_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Ford Antenna XCnd", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.label13.Location = new System.Drawing.Point(718, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 26);
            this.label13.TabIndex = 20;
            this.label13.Text = "Documento";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Turnos.Properties.Resources.btnActualizar;
            this.button2.Location = new System.Drawing.Point(551, 618);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 62);
            this.button2.TabIndex = 17;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ford Antenna XCnd", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.label5.Location = new System.Drawing.Point(74, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cargo";
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = global::Turnos.Properties.Resources.btnGuardar;
            this.btnGuardar.Location = new System.Drawing.Point(380, 618);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(123, 62);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtDocumento
            // 
            this.txtDocumento.Font = new System.Drawing.Font("Ford Antenna XCnd", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(158, 39);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(189, 34);
            this.txtDocumento.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ford Antenna XCnd", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(78, 491);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "Sede";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Ford Antenna XCnd", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(158, 119);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(189, 34);
            this.txtNombre.TabIndex = 2;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Ford Antenna XCnd", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(158, 202);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(189, 34);
            this.txtApellidos.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ford Antenna XCnd", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.label4.Location = new System.Drawing.Point(50, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Ford Antenna XCnd", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(158, 289);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(189, 34);
            this.txtTelefono.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ford Antenna XCnd", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.label3.Location = new System.Drawing.Point(45, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Apellidos";
            // 
            // cboCargo
            // 
            this.cboCargo.Font = new System.Drawing.Font("Ford Antenna XCnd", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Location = new System.Drawing.Point(159, 389);
            this.cboCargo.Margin = new System.Windows.Forms.Padding(4);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(240, 34);
            this.cboCargo.TabIndex = 5;
            this.cboCargo.Text = "Seleccione...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ford Antenna XCnd", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(40, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombres";
            // 
            // cboSede
            // 
            this.cboSede.Font = new System.Drawing.Font("Ford Antenna XCnd", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSede.FormattingEnabled = true;
            this.cboSede.Location = new System.Drawing.Point(158, 491);
            this.cboSede.Margin = new System.Windows.Forms.Padding(4);
            this.cboSede.Name = "cboSede";
            this.cboSede.Size = new System.Drawing.Size(241, 34);
            this.cboSede.TabIndex = 6;
            this.cboSede.Text = "Seleccione...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ford Antenna XCnd", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(16, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Documento";
            // 
            // ActualizarDatosEmpleado
            // 
            this.ActualizarDatosEmpleado.Controls.Add(this.panel2);
            this.ActualizarDatosEmpleado.Location = new System.Drawing.Point(4, 25);
            this.ActualizarDatosEmpleado.Name = "ActualizarDatosEmpleado";
            this.ActualizarDatosEmpleado.Size = new System.Drawing.Size(1337, 1594);
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
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1337, 1594);
            this.panel2.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ford Antenna XCnd", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.label8.Location = new System.Drawing.Point(405, 559);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 38);
            this.label8.TabIndex = 15;
            this.label8.Text = "Sede";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ford Antenna XCnd", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.label7.Location = new System.Drawing.Point(406, 471);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 38);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cargo";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Turnos.Properties.Resources.btnGuardar;
            this.button1.Location = new System.Drawing.Point(428, 698);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 52);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbActDocumento
            // 
            this.tbActDocumento.Font = new System.Drawing.Font("Ford Antenna XCnd", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbActDocumento.Location = new System.Drawing.Point(551, 130);
            this.tbActDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.tbActDocumento.Name = "tbActDocumento";
            this.tbActDocumento.Size = new System.Drawing.Size(235, 38);
            this.tbActDocumento.TabIndex = 1;
            // 
            // tbActNombres
            // 
            this.tbActNombres.Font = new System.Drawing.Font("Ford Antenna XCnd", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbActNombres.Location = new System.Drawing.Point(551, 210);
            this.tbActNombres.Margin = new System.Windows.Forms.Padding(4);
            this.tbActNombres.Name = "tbActNombres";
            this.tbActNombres.Size = new System.Drawing.Size(235, 38);
            this.tbActNombres.TabIndex = 2;
            // 
            // tbActApellidos
            // 
            this.tbActApellidos.Font = new System.Drawing.Font("Ford Antenna XCnd", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbActApellidos.Location = new System.Drawing.Point(551, 293);
            this.tbActApellidos.Margin = new System.Windows.Forms.Padding(4);
            this.tbActApellidos.Name = "tbActApellidos";
            this.tbActApellidos.Size = new System.Drawing.Size(235, 38);
            this.tbActApellidos.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Ford Antenna XCnd", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.label9.Location = new System.Drawing.Point(382, 383);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 38);
            this.label9.TabIndex = 11;
            this.label9.Text = "Teléfono";
            // 
            // tbActTelefono
            // 
            this.tbActTelefono.Font = new System.Drawing.Font("Ford Antenna XCnd", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbActTelefono.Location = new System.Drawing.Point(551, 380);
            this.tbActTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.tbActTelefono.Name = "tbActTelefono";
            this.tbActTelefono.Size = new System.Drawing.Size(235, 38);
            this.tbActTelefono.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Ford Antenna XCnd", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.label10.Location = new System.Drawing.Point(377, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 38);
            this.label10.TabIndex = 10;
            this.label10.Text = "Apellidos";
            // 
            // cboActCargo
            // 
            this.cboActCargo.Font = new System.Drawing.Font("Ford Antenna XCnd", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboActCargo.FormattingEnabled = true;
            this.cboActCargo.Location = new System.Drawing.Point(543, 470);
            this.cboActCargo.Margin = new System.Windows.Forms.Padding(4);
            this.cboActCargo.Name = "cboActCargo";
            this.cboActCargo.Size = new System.Drawing.Size(240, 38);
            this.cboActCargo.TabIndex = 5;
            this.cboActCargo.Text = "Seleccione...";
            this.cboActCargo.SelectedIndexChanged += new System.EventHandler(this.cboActCargo_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Ford Antenna XCnd", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.label11.Location = new System.Drawing.Point(372, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 38);
            this.label11.TabIndex = 9;
            this.label11.Text = "Nombres";
            // 
            // cbActSede
            // 
            this.cbActSede.Font = new System.Drawing.Font("Ford Antenna XCnd", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbActSede.FormattingEnabled = true;
            this.cbActSede.Location = new System.Drawing.Point(542, 562);
            this.cbActSede.Margin = new System.Windows.Forms.Padding(4);
            this.cbActSede.Name = "cbActSede";
            this.cbActSede.Size = new System.Drawing.Size(241, 38);
            this.cbActSede.TabIndex = 6;
            this.cbActSede.Text = "Seleccione...";
            this.cbActSede.SelectedIndexChanged += new System.EventHandler(this.cbActSede_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Ford Antenna XCnd", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.label12.Location = new System.Drawing.Point(348, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 38);
            this.label12.TabIndex = 8;
            this.label12.Text = "Documento";
            // 
            // pnAsistencia
            // 
            this.pnAsistencia.Controls.Add(this.btnIngreso);
            this.pnAsistencia.Location = new System.Drawing.Point(3, 5);
            this.pnAsistencia.Name = "pnAsistencia";
            this.pnAsistencia.Size = new System.Drawing.Size(1334, 725);
            this.pnAsistencia.TabIndex = 0;
            // 
            // btnIngreso
            // 
            this.btnIngreso.Location = new System.Drawing.Point(232, 245);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(75, 54);
            this.btnIngreso.TabIndex = 0;
            this.btnIngreso.Text = "Registrar Ingreso";
            this.btnIngreso.UseVisualStyleBackColor = true;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Ford Antenna XCnd", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblTitulo.Location = new System.Drawing.Point(936, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(0, 50);
            this.lblTitulo.TabIndex = 0;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 895);
            this.Controls.Add(this.TabPrincipal);
            this.Controls.Add(this.pnTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.Empleados.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgListadoEmpleados)).EndInit();
            this.ActualizarDatosEmpleado.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnAsistencia.ResumeLayout(false);
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
    }
}

