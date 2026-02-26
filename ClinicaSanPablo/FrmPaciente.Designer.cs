namespace ClinicaSanPablo
{
    partial class FrmPaciente
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
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.lblEdadCalculada = new System.Windows.Forms.Label();
            this.txtApelMaterno = new System.Windows.Forms.TextBox();
            this.txtApelPaterno = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnIrHospitalizacion = new System.Windows.Forms.Button();
            this.btnIrCirugia = new System.Windows.Forms.Button();
            this.btnIrEmergencia = new System.Windows.Forms.Button();
            this.txtNumOrden = new System.Windows.Forms.TextBox();
            this.lblNumOrden = new System.Windows.Forms.Label();
            this.btnPersonalMedico = new System.Windows.Forms.Button();
            this.lblTraslado = new System.Windows.Forms.Label();
            this.cmbTraslado = new System.Windows.Forms.ComboBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblBuscarPaciente = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.btnMostrarPaciente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(12, 338);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(205, 20);
            this.dtpFechaNac.TabIndex = 0;
            this.dtpFechaNac.ValueChanged += new System.EventHandler(this.dtpFechaNac_ValueChanged);
            // 
            // lblEdadCalculada
            // 
            this.lblEdadCalculada.AutoSize = true;
            this.lblEdadCalculada.Location = new System.Drawing.Point(12, 322);
            this.lblEdadCalculada.Name = "lblEdadCalculada";
            this.lblEdadCalculada.Size = new System.Drawing.Size(32, 13);
            this.lblEdadCalculada.TabIndex = 1;
            this.lblEdadCalculada.Text = "Edad";
            // 
            // txtApelMaterno
            // 
            this.txtApelMaterno.Location = new System.Drawing.Point(12, 152);
            this.txtApelMaterno.Name = "txtApelMaterno";
            this.txtApelMaterno.Size = new System.Drawing.Size(100, 20);
            this.txtApelMaterno.TabIndex = 2;
            // 
            // txtApelPaterno
            // 
            this.txtApelPaterno.Location = new System.Drawing.Point(12, 113);
            this.txtApelPaterno.Name = "txtApelPaterno";
            this.txtApelPaterno.Size = new System.Drawing.Size(100, 20);
            this.txtApelPaterno.TabIndex = 3;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(12, 292);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(100, 20);
            this.txtCelular.TabIndex = 4;
            this.txtCelular.TextChanged += new System.EventHandler(this.txtCelular_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Apellido Materno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apellido Paterno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Numero de celular";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "DNI";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(12, 191);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 12;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(431, 395);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(86, 56);
            this.btnRegistrar.TabIndex = 13;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(536, 395);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(86, 56);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnIrHospitalizacion
            // 
            this.btnIrHospitalizacion.Location = new System.Drawing.Point(919, 435);
            this.btnIrHospitalizacion.Name = "btnIrHospitalizacion";
            this.btnIrHospitalizacion.Size = new System.Drawing.Size(101, 34);
            this.btnIrHospitalizacion.TabIndex = 16;
            this.btnIrHospitalizacion.Text = "Hospitalizacion";
            this.btnIrHospitalizacion.UseVisualStyleBackColor = true;
            this.btnIrHospitalizacion.Click += new System.EventHandler(this.btnIrHospitalizacion_Click);
            // 
            // btnIrCirugia
            // 
            this.btnIrCirugia.Location = new System.Drawing.Point(919, 475);
            this.btnIrCirugia.Name = "btnIrCirugia";
            this.btnIrCirugia.Size = new System.Drawing.Size(101, 34);
            this.btnIrCirugia.TabIndex = 17;
            this.btnIrCirugia.Text = "Cirujia";
            this.btnIrCirugia.UseVisualStyleBackColor = true;
            this.btnIrCirugia.Click += new System.EventHandler(this.btnIrCirugia_Click);
            // 
            // btnIrEmergencia
            // 
            this.btnIrEmergencia.Location = new System.Drawing.Point(919, 395);
            this.btnIrEmergencia.Name = "btnIrEmergencia";
            this.btnIrEmergencia.Size = new System.Drawing.Size(101, 34);
            this.btnIrEmergencia.TabIndex = 18;
            this.btnIrEmergencia.Text = "Emergencia";
            this.btnIrEmergencia.UseVisualStyleBackColor = true;
            this.btnIrEmergencia.Click += new System.EventHandler(this.btnIrEmergencia_Click);
            // 
            // txtNumOrden
            // 
            this.txtNumOrden.Location = new System.Drawing.Point(12, 25);
            this.txtNumOrden.Name = "txtNumOrden";
            this.txtNumOrden.Size = new System.Drawing.Size(100, 20);
            this.txtNumOrden.TabIndex = 19;
            this.txtNumOrden.TextChanged += new System.EventHandler(this.txtNumOrden_TextChanged);
            // 
            // lblNumOrden
            // 
            this.lblNumOrden.AutoSize = true;
            this.lblNumOrden.Location = new System.Drawing.Point(12, 9);
            this.lblNumOrden.Name = "lblNumOrden";
            this.lblNumOrden.Size = new System.Drawing.Size(91, 13);
            this.lblNumOrden.TabIndex = 20;
            this.lblNumOrden.Text = "Numero de Orden";
            // 
            // btnPersonalMedico
            // 
            this.btnPersonalMedico.Location = new System.Drawing.Point(919, 515);
            this.btnPersonalMedico.Name = "btnPersonalMedico";
            this.btnPersonalMedico.Size = new System.Drawing.Size(101, 34);
            this.btnPersonalMedico.TabIndex = 21;
            this.btnPersonalMedico.Text = "Personal Medico";
            this.btnPersonalMedico.UseVisualStyleBackColor = true;
            this.btnPersonalMedico.Click += new System.EventHandler(this.btnPersonalMedico_Click);
            // 
            // lblTraslado
            // 
            this.lblTraslado.AutoSize = true;
            this.lblTraslado.Location = new System.Drawing.Point(9, 214);
            this.lblTraslado.Name = "lblTraslado";
            this.lblTraslado.Size = new System.Drawing.Size(60, 13);
            this.lblTraslado.TabIndex = 22;
            this.lblTraslado.Text = "Traslado a:";
            this.lblTraslado.Click += new System.EventHandler(this.label6_Click);
            // 
            // cmbTraslado
            // 
            this.cmbTraslado.FormattingEnabled = true;
            this.cmbTraslado.Items.AddRange(new object[] {
            "Hospitalizacion",
            "Emergencia",
            "Cirugia"});
            this.cmbTraslado.Location = new System.Drawing.Point(12, 239);
            this.cmbTraslado.Name = "cmbTraslado";
            this.cmbTraslado.Size = new System.Drawing.Size(121, 21);
            this.cmbTraslado.TabIndex = 23;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(12, 381);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(100, 20);
            this.txtBusqueda.TabIndex = 24;
            // 
            // lblBuscarPaciente
            // 
            this.lblBuscarPaciente.AutoSize = true;
            this.lblBuscarPaciente.Location = new System.Drawing.Point(9, 365);
            this.lblBuscarPaciente.Name = "lblBuscarPaciente";
            this.lblBuscarPaciente.Size = new System.Drawing.Size(82, 13);
            this.lblBuscarPaciente.TabIndex = 25;
            this.lblBuscarPaciente.Text = "BuscarPaciente";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(7, 407);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(105, 32);
            this.btnBuscar.TabIndex = 26;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Location = new System.Drawing.Point(223, 25);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.Size = new System.Drawing.Size(797, 364);
            this.dgvPacientes.TabIndex = 27;
            this.dgvPacientes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // btnMostrarPaciente
            // 
            this.btnMostrarPaciente.Location = new System.Drawing.Point(223, 395);
            this.btnMostrarPaciente.Name = "btnMostrarPaciente";
            this.btnMostrarPaciente.Size = new System.Drawing.Size(100, 23);
            this.btnMostrarPaciente.TabIndex = 28;
            this.btnMostrarPaciente.Text = "Mostrar Pacientes";
            this.btnMostrarPaciente.UseVisualStyleBackColor = true;
            this.btnMostrarPaciente.Click += new System.EventHandler(this.btnMostrarPaciente_Click);
            // 
            // FrmPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 561);
            this.Controls.Add(this.btnMostrarPaciente);
            this.Controls.Add(this.dgvPacientes);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblBuscarPaciente);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.cmbTraslado);
            this.Controls.Add(this.lblTraslado);
            this.Controls.Add(this.btnPersonalMedico);
            this.Controls.Add(this.lblNumOrden);
            this.Controls.Add(this.txtNumOrden);
            this.Controls.Add(this.btnIrEmergencia);
            this.Controls.Add(this.btnIrCirugia);
            this.Controls.Add(this.btnIrHospitalizacion);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtApelPaterno);
            this.Controls.Add(this.txtApelMaterno);
            this.Controls.Add(this.lblEdadCalculada);
            this.Controls.Add(this.dtpFechaNac);
            this.Name = "FrmPaciente";
            this.Text = "FrmPaciente";
            this.Load += new System.EventHandler(this.FrmPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.Label lblEdadCalculada;
        private System.Windows.Forms.TextBox txtApelMaterno;
        private System.Windows.Forms.TextBox txtApelPaterno;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnIrHospitalizacion;
        private System.Windows.Forms.Button btnIrCirugia;
        private System.Windows.Forms.Button btnIrEmergencia;
        private System.Windows.Forms.TextBox txtNumOrden;
        private System.Windows.Forms.Label lblNumOrden;
        private System.Windows.Forms.Button btnPersonalMedico;
        private System.Windows.Forms.Label lblTraslado;
        private System.Windows.Forms.ComboBox cmbTraslado;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblBuscarPaciente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.Button btnMostrarPaciente;
    }
}