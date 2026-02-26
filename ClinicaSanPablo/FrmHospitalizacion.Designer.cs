namespace ClinicaSanPablo
{
    partial class FrmHospitalizacion
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblOrdenMedica = new System.Windows.Forms.Label();
            this.lblFechaProbable = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblCama = new System.Windows.Forms.Label();
            this.txtDniPaciente = new System.Windows.Forms.TextBox();
            this.txtNumeroCama = new System.Windows.Forms.TextBox();
            this.txtOrdenMedica = new System.Windows.Forms.TextBox();
            this.dtpFechaProbable = new System.Windows.Forms.DateTimePicker();
            this.dgvHospitalizacion = new System.Windows.Forms.DataGridView();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.btnReservar = new System.Windows.Forms.Button();
            this.btnRegistrarIngreso = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCirugia = new System.Windows.Forms.Button();
            this.btnRegistrarPaciente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHospitalizacion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(265, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(176, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "PROCESO DE HOSPITALIZACIÓN";
            // 
            // lblOrdenMedica
            // 
            this.lblOrdenMedica.AutoSize = true;
            this.lblOrdenMedica.Location = new System.Drawing.Point(12, 50);
            this.lblOrdenMedica.Name = "lblOrdenMedica";
            this.lblOrdenMedica.Size = new System.Drawing.Size(100, 13);
            this.lblOrdenMedica.TabIndex = 1;
            this.lblOrdenMedica.Text = "Nro. Orden Médica:";
            // 
            // lblFechaProbable
            // 
            this.lblFechaProbable.AutoSize = true;
            this.lblFechaProbable.Location = new System.Drawing.Point(12, 102);
            this.lblFechaProbable.Name = "lblFechaProbable";
            this.lblFechaProbable.Size = new System.Drawing.Size(123, 13);
            this.lblFechaProbable.TabIndex = 2;
            this.lblFechaProbable.Text = "Fecha Probable Ingreso:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(9, 141);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(74, 13);
            this.lblDni.TabIndex = 3;
            this.lblDni.Text = "DNI Paciente:";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(8, 189);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(120, 13);
            this.lblEspecialidad.TabIndex = 4;
            this.lblEspecialidad.Text = "Especialidad/Tipo Sala:";
            // 
            // lblCama
            // 
            this.lblCama.AutoSize = true;
            this.lblCama.Location = new System.Drawing.Point(12, 248);
            this.lblCama.Name = "lblCama";
            this.lblCama.Size = new System.Drawing.Size(92, 13);
            this.lblCama.TabIndex = 5;
            this.lblCama.Text = "Número de Cama:";
            // 
            // txtDniPaciente
            // 
            this.txtDniPaciente.Location = new System.Drawing.Point(11, 157);
            this.txtDniPaciente.Name = "txtDniPaciente";
            this.txtDniPaciente.Size = new System.Drawing.Size(100, 20);
            this.txtDniPaciente.TabIndex = 6;
            // 
            // txtNumeroCama
            // 
            this.txtNumeroCama.Location = new System.Drawing.Point(15, 276);
            this.txtNumeroCama.Name = "txtNumeroCama";
            this.txtNumeroCama.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroCama.TabIndex = 7;
            // 
            // txtOrdenMedica
            // 
            this.txtOrdenMedica.Location = new System.Drawing.Point(12, 66);
            this.txtOrdenMedica.Name = "txtOrdenMedica";
            this.txtOrdenMedica.Size = new System.Drawing.Size(100, 20);
            this.txtOrdenMedica.TabIndex = 8;
            // 
            // dtpFechaProbable
            // 
            this.dtpFechaProbable.Location = new System.Drawing.Point(11, 118);
            this.dtpFechaProbable.Name = "dtpFechaProbable";
            this.dtpFechaProbable.Size = new System.Drawing.Size(227, 20);
            this.dtpFechaProbable.TabIndex = 9;
            // 
            // dgvHospitalizacion
            // 
            this.dgvHospitalizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHospitalizacion.Location = new System.Drawing.Point(268, 50);
            this.dgvHospitalizacion.Name = "dgvHospitalizacion";
            this.dgvHospitalizacion.Size = new System.Drawing.Size(699, 377);
            this.dgvHospitalizacion.TabIndex = 10;
            this.dgvHospitalizacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHospitalizacion_CellContentClick);
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Items.AddRange(new object[] {
            "Anestesiología",
            "Cardiología",
            "Cirugía Cardiovascular",
            "Cirugía de Cabeza y Cuello",
            "Cirugía General y Laparoscópica",
            "Cirugía Artroscópicas",
            "Cirugía de Mano",
            "Cirugía Oncológica",
            "Cirugía Plástica y Quemados",
            "Cirugía Pediátrica",
            "Dermatología",
            "Endocrinología",
            "Gastroenterología",
            "Ginecología y Obstetricia",
            "Geriatría",
            "Hematología",
            "Infectología y Toxicología",
            "Inmunología y Alergía",
            "Mastología",
            "Medicina Física y Rehabilitación",
            "Medicina Interna",
            "Neonatología",
            "Neumología",
            "Neurocirugía",
            "Neurología",
            "Nefrología",
            "Nutrición y Dietética",
            "Odontología",
            "Odontología Pediátrica",
            "Oftalmología",
            "Oncología Médica",
            "Otorrinolaringología",
            "Pediatría y Sub especialidades Pediátricas",
            "Psicología",
            "Psiquiatría",
            "Reumatología",
            "Traumatología",
            "Urología"});
            this.cmbEspecialidad.Location = new System.Drawing.Point(11, 205);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(113, 21);
            this.cmbEspecialidad.TabIndex = 11;
            this.cmbEspecialidad.SelectedIndexChanged += new System.EventHandler(this.cmbEspecialidad_SelectedIndexChanged);
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(11, 302);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(93, 50);
            this.btnReservar.TabIndex = 12;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // btnRegistrarIngreso
            // 
            this.btnRegistrarIngreso.Location = new System.Drawing.Point(15, 358);
            this.btnRegistrarIngreso.Name = "btnRegistrarIngreso";
            this.btnRegistrarIngreso.Size = new System.Drawing.Size(93, 50);
            this.btnRegistrarIngreso.TabIndex = 13;
            this.btnRegistrarIngreso.Text = "Registrar Ingreso";
            this.btnRegistrarIngreso.UseVisualStyleBackColor = true;
            this.btnRegistrarIngreso.Click += new System.EventHandler(this.btnRegistrarIngreso_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(15, 418);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(93, 50);
            this.btnAnular.TabIndex = 14;
            this.btnAnular.Text = "Anular Reserva";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(879, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 40);
            this.button1.TabIndex = 15;
            this.button1.Text = "Emergencia";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCirugia
            // 
            this.btnCirugia.Location = new System.Drawing.Point(879, 512);
            this.btnCirugia.Name = "btnCirugia";
            this.btnCirugia.Size = new System.Drawing.Size(88, 40);
            this.btnCirugia.TabIndex = 16;
            this.btnCirugia.Text = "Cirugia";
            this.btnCirugia.UseVisualStyleBackColor = true;
            this.btnCirugia.Click += new System.EventHandler(this.btnCirugia_Click);
            // 
            // btnRegistrarPaciente
            // 
            this.btnRegistrarPaciente.Location = new System.Drawing.Point(803, 12);
            this.btnRegistrarPaciente.Name = "btnRegistrarPaciente";
            this.btnRegistrarPaciente.Size = new System.Drawing.Size(164, 23);
            this.btnRegistrarPaciente.TabIndex = 17;
            this.btnRegistrarPaciente.Text = "Registrar Nuevo Paciente";
            this.btnRegistrarPaciente.UseVisualStyleBackColor = true;
            this.btnRegistrarPaciente.Click += new System.EventHandler(this.btnRegistrarPaciente_Click);
            // 
            // FrmHospitalizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 560);
            this.Controls.Add(this.btnRegistrarPaciente);
            this.Controls.Add(this.btnCirugia);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnRegistrarIngreso);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.dgvHospitalizacion);
            this.Controls.Add(this.dtpFechaProbable);
            this.Controls.Add(this.txtOrdenMedica);
            this.Controls.Add(this.txtNumeroCama);
            this.Controls.Add(this.txtDniPaciente);
            this.Controls.Add(this.lblCama);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblFechaProbable);
            this.Controls.Add(this.lblOrdenMedica);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmHospitalizacion";
            this.Text = "FrmHospitalizacion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHospitalizacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblOrdenMedica;
        private System.Windows.Forms.Label lblFechaProbable;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblCama;
        private System.Windows.Forms.TextBox txtDniPaciente;
        private System.Windows.Forms.TextBox txtNumeroCama;
        private System.Windows.Forms.TextBox txtOrdenMedica;
        private System.Windows.Forms.DateTimePicker dtpFechaProbable;
        private System.Windows.Forms.DataGridView dgvHospitalizacion;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnRegistrarIngreso;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCirugia;
        private System.Windows.Forms.Button btnRegistrarPaciente;
    }
}