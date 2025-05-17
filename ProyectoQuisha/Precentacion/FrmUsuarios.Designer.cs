namespace ProyectoQuisha
{
    partial class FrmUsuarios
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
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoEmpleado = new System.Windows.Forms.TextBox();
            this.CboxRol = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxEstado = new System.Windows.Forms.ComboBox();
            this.DgvUsuarios = new System.Windows.Forms.DataGridView();
            this.clmCodigoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCodigoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmNombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmPASS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmROL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmPuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmUsuarioSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmFechaSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodigoUsuario = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.cboxPuesto = new System.Windows.Forms.ComboBox();
            this.lblCodigoEmpleado = new System.Windows.Forms.Label();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.lblPASS = new System.Windows.Forms.Label();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.txtPASS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(321, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 39);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tabla de Usuarios.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Codigo Empleado:";
            // 
            // txtCodigoEmpleado
            // 
            this.txtCodigoEmpleado.Location = new System.Drawing.Point(170, 76);
            this.txtCodigoEmpleado.Name = "txtCodigoEmpleado";
            this.txtCodigoEmpleado.Size = new System.Drawing.Size(152, 25);
            this.txtCodigoEmpleado.TabIndex = 18;
            // 
            // CboxRol
            // 
            this.CboxRol.FormattingEnabled = true;
            this.CboxRol.Items.AddRange(new object[] {
            "Admin",
            "Ejecutivo",
            "Asistente",
            "Dijitador"});
            this.CboxRol.Location = new System.Drawing.Point(171, 186);
            this.CboxRol.Name = "CboxRol";
            this.CboxRol.Size = new System.Drawing.Size(152, 26);
            this.CboxRol.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Rol del Empleado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(377, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Estado:";
            // 
            // cboxEstado
            // 
            this.cboxEstado.FormattingEnabled = true;
            this.cboxEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboxEstado.Location = new System.Drawing.Point(436, 40);
            this.cboxEstado.Name = "cboxEstado";
            this.cboxEstado.Size = new System.Drawing.Size(152, 26);
            this.cboxEstado.TabIndex = 22;
            // 
            // DgvUsuarios
            // 
            this.DgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigoUsuario,
            this.clmCodigoEmpleado,
            this.ClmNombreUsuario,
            this.ClmPASS,
            this.ClmROL,
            this.ClmEstado,
            this.ClmPuesto,
            this.ClmUsuarioSistema,
            this.ClmFechaSistema});
            this.DgvUsuarios.Location = new System.Drawing.Point(26, 299);
            this.DgvUsuarios.Name = "DgvUsuarios";
            this.DgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvUsuarios.Size = new System.Drawing.Size(831, 214);
            this.DgvUsuarios.TabIndex = 42;
            this.DgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEmpleados_CellClick);
            // 
            // clmCodigoUsuario
            // 
            this.clmCodigoUsuario.HeaderText = "Codigo Usuario";
            this.clmCodigoUsuario.Name = "clmCodigoUsuario";
            // 
            // clmCodigoEmpleado
            // 
            this.clmCodigoEmpleado.HeaderText = "Codigo Empleado";
            this.clmCodigoEmpleado.Name = "clmCodigoEmpleado";
            // 
            // ClmNombreUsuario
            // 
            this.ClmNombreUsuario.HeaderText = "Nombre Usuario";
            this.ClmNombreUsuario.Name = "ClmNombreUsuario";
            // 
            // ClmPASS
            // 
            this.ClmPASS.HeaderText = "Contraseña";
            this.ClmPASS.Name = "ClmPASS";
            // 
            // ClmROL
            // 
            this.ClmROL.HeaderText = "Rol";
            this.ClmROL.Name = "ClmROL";
            // 
            // ClmEstado
            // 
            this.ClmEstado.HeaderText = "Estado";
            this.ClmEstado.Name = "ClmEstado";
            // 
            // ClmPuesto
            // 
            this.ClmPuesto.HeaderText = "Puesto";
            this.ClmPuesto.Name = "ClmPuesto";
            // 
            // ClmUsuarioSistema
            // 
            this.ClmUsuarioSistema.HeaderText = "Usuario Sistema";
            this.ClmUsuarioSistema.Name = "ClmUsuarioSistema";
            // 
            // ClmFechaSistema
            // 
            this.ClmFechaSistema.HeaderText = "Fecha Sistema";
            this.ClmFechaSistema.Name = "ClmFechaSistema";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(685, -35);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(95, 15);
            this.lblFecha.TabIndex = 40;
            this.lblFecha.Text = "Imprimir Fecha";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(592, -37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 15);
            this.label10.TabIndex = 41;
            this.label10.Text = "Fecha actual:";
            // 
            // btnSalir
            // 
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnSalir.IconColor = System.Drawing.Color.Black;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 25;
            this.btnSalir.Location = new System.Drawing.Point(752, 530);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(91, 30);
            this.btnSalir.TabIndex = 39;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminar.IconColor = System.Drawing.Color.Black;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 25;
            this.btnEliminar.Location = new System.Drawing.Point(655, 530);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(91, 30);
            this.btnEliminar.TabIndex = 38;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCodigoUsuario);
            this.groupBox1.Controls.Add(this.txtNombreUsuario);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lblPuesto);
            this.groupBox1.Controls.Add(this.cboxPuesto);
            this.groupBox1.Controls.Add(this.lblCodigoEmpleado);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.cboxEstado);
            this.groupBox1.Controls.Add(this.lblPASS);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CboxRol);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.txtPASS);
            this.groupBox1.Controls.Add(this.txtCodigoEmpleado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(26, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(831, 224);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtCodigoUsuario
            // 
            this.txtCodigoUsuario.Location = new System.Drawing.Point(170, 41);
            this.txtCodigoUsuario.Name = "txtCodigoUsuario";
            this.txtCodigoUsuario.Size = new System.Drawing.Size(152, 25);
            this.txtCodigoUsuario.TabIndex = 18;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(170, 111);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(152, 25);
            this.txtNombreUsuario.TabIndex = 17;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(43, 114);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(114, 18);
            this.lblNombre.TabIndex = 16;
            this.lblNombre.Text = "Nombre Usuario:";
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.Location = new System.Drawing.Point(377, 79);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(59, 18);
            this.lblPuesto.TabIndex = 1;
            this.lblPuesto.Text = "Puestos:";
            // 
            // cboxPuesto
            // 
            this.cboxPuesto.FormattingEnabled = true;
            this.cboxPuesto.Items.AddRange(new object[] {
            "Gerente",
            "Recepcionista",
            "Botones",
            "Conserje",
            "Chef"});
            this.cboxPuesto.Location = new System.Drawing.Point(436, 76);
            this.cboxPuesto.Name = "cboxPuesto";
            this.cboxPuesto.Size = new System.Drawing.Size(152, 26);
            this.cboxPuesto.TabIndex = 0;
            // 
            // lblCodigoEmpleado
            // 
            this.lblCodigoEmpleado.AutoSize = true;
            this.lblCodigoEmpleado.Location = new System.Drawing.Point(43, 44);
            this.lblCodigoEmpleado.Name = "lblCodigoEmpleado";
            this.lblCodigoEmpleado.Size = new System.Drawing.Size(108, 18);
            this.lblCodigoEmpleado.TabIndex = 15;
            this.lblCodigoEmpleado.Text = "Codigo Usuario:";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.SquarePen;
            this.btnEditar.IconColor = System.Drawing.Color.Black;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.IconSize = 25;
            this.btnEditar.Location = new System.Drawing.Point(704, 76);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(113, 35);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblPASS
            // 
            this.lblPASS.AutoSize = true;
            this.lblPASS.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPASS.Location = new System.Drawing.Point(43, 148);
            this.lblPASS.Name = "lblPASS";
            this.lblPASS.Size = new System.Drawing.Size(81, 18);
            this.lblPASS.TabIndex = 2;
            this.lblPASS.Text = "Contraseña:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.btnCancelar.IconColor = System.Drawing.Color.Black;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 25;
            this.btnCancelar.Location = new System.Drawing.Point(704, 131);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 35);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAgregar.IconColor = System.Drawing.Color.Black;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 25;
            this.btnAgregar.Location = new System.Drawing.Point(704, 24);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(113, 35);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtPASS
            // 
            this.txtPASS.Location = new System.Drawing.Point(171, 148);
            this.txtPASS.Name = "txtPASS";
            this.txtPASS.Size = new System.Drawing.Size(151, 25);
            this.txtPASS.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(215, -55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 39);
            this.label4.TabIndex = 36;
            this.label4.Text = "Tabla de Empleados.";
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(875, 580);
            this.Controls.Add(this.DgvUsuarios);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Name = "FrmUsuarios";
            this.Text = "tbl_Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoEmpleado;
        private System.Windows.Forms.ComboBox CboxRol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxEstado;
        private System.Windows.Forms.DataGridView DgvUsuarios;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCodigoUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.ComboBox cboxPuesto;
        private System.Windows.Forms.Label lblCodigoEmpleado;
        private FontAwesome.Sharp.IconButton btnEditar;
        private System.Windows.Forms.Label lblPASS;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private System.Windows.Forms.TextBox txtPASS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmNombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmPASS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmROL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmPuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmUsuarioSistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmFechaSistema;
    }
}