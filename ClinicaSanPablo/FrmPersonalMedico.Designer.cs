namespace ClinicaSanPablo
{
    partial class FrmPersonalMedico
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblLicencia = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtLicencia = new System.Windows.Forms.TextBox();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnInhabilitar = new System.Windows.Forms.Button();
            this.dgvPersonal = new System.Windows.Forms.DataGridView();
            this.btnHospitalizacion = new System.Windows.Forms.Button();
            this.btnCirugia = new System.Windows.Forms.Button();
            this.btnEmergencia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(22, 46);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(94, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre Completo:";
            // 
            // lblLicencia
            // 
            this.lblLicencia.AutoSize = true;
            this.lblLicencia.Location = new System.Drawing.Point(22, 111);
            this.lblLicencia.Name = "lblLicencia";
            this.lblLicencia.Size = new System.Drawing.Size(105, 13);
            this.lblLicencia.TabIndex = 1;
            this.lblLicencia.Text = "Número de Licencia:";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(22, 165);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(70, 13);
            this.lblEspecialidad.TabIndex = 2;
            this.lblEspecialidad.Text = "Especialidad:";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(22, 221);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(38, 13);
            this.lblTurno.TabIndex = 3;
            this.lblTurno.Text = "Turno:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(22, 291);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(25, 72);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(126, 20);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtLicencia
            // 
            this.txtLicencia.Location = new System.Drawing.Point(25, 127);
            this.txtLicencia.Name = "txtLicencia";
            this.txtLicencia.Size = new System.Drawing.Size(126, 20);
            this.txtLicencia.TabIndex = 6;
            this.txtLicencia.TextChanged += new System.EventHandler(this.txtLicencia_TextChanged);
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Items.AddRange(new object[] {
            "Cirujano ",
            "Enfermería ",
            "Anestesiólogo",
            " Médico General",
            "Emergencia"});
            this.cmbEspecialidad.Location = new System.Drawing.Point(25, 181);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(136, 21);
            this.cmbEspecialidad.TabIndex = 7;
            this.cmbEspecialidad.SelectedIndexChanged += new System.EventHandler(this.cmbEspecialidad_SelectedIndexChanged);
            // 
            // cmbTurno
            // 
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Items.AddRange(new object[] {
            "Mañana",
            "Tarde",
            "Noche",
            "Amanecida/Madrugada."});
            this.cmbTurno.Location = new System.Drawing.Point(25, 249);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(136, 21);
            this.cmbTurno.TabIndex = 8;
            this.cmbTurno.SelectedIndexChanged += new System.EventHandler(this.cmbTurno_SelectedIndexChanged);
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(25, 320);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(15, 14);
            this.chkActivo.TabIndex = 9;
            this.chkActivo.UseVisualStyleBackColor = true;
            this.chkActivo.CheckedChanged += new System.EventHandler(this.chkActivo_CheckedChanged);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(25, 340);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(90, 55);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(25, 401);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(90, 55);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar Datos";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.Location = new System.Drawing.Point(25, 462);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(90, 55);
            this.btnInhabilitar.TabIndex = 12;
            this.btnInhabilitar.Text = "Inhabilitar";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            this.btnInhabilitar.Click += new System.EventHandler(this.btnInhabilitar_Click);
            // 
            // dgvPersonal
            // 
            this.dgvPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonal.Location = new System.Drawing.Point(210, 28);
            this.dgvPersonal.Name = "dgvPersonal";
            this.dgvPersonal.Size = new System.Drawing.Size(684, 367);
            this.dgvPersonal.TabIndex = 13;
            this.dgvPersonal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonal_CellContentClick);
            // 
            // btnHospitalizacion
            // 
            this.btnHospitalizacion.Location = new System.Drawing.Point(770, 401);
            this.btnHospitalizacion.Name = "btnHospitalizacion";
            this.btnHospitalizacion.Size = new System.Drawing.Size(124, 38);
            this.btnHospitalizacion.TabIndex = 14;
            this.btnHospitalizacion.Text = "Hospitalizacion ";
            this.btnHospitalizacion.UseVisualStyleBackColor = true;
            this.btnHospitalizacion.Click += new System.EventHandler(this.btnHospitalizacion_Click);
            // 
            // btnCirugia
            // 
            this.btnCirugia.Location = new System.Drawing.Point(770, 445);
            this.btnCirugia.Name = "btnCirugia";
            this.btnCirugia.Size = new System.Drawing.Size(124, 39);
            this.btnCirugia.TabIndex = 15;
            this.btnCirugia.Text = "Cirugia";
            this.btnCirugia.UseVisualStyleBackColor = true;
            this.btnCirugia.Click += new System.EventHandler(this.btnCirugia_Click);
            // 
            // btnEmergencia
            // 
            this.btnEmergencia.Location = new System.Drawing.Point(770, 490);
            this.btnEmergencia.Name = "btnEmergencia";
            this.btnEmergencia.Size = new System.Drawing.Size(124, 39);
            this.btnEmergencia.TabIndex = 16;
            this.btnEmergencia.Text = "Emergencia";
            this.btnEmergencia.UseVisualStyleBackColor = true;
            this.btnEmergencia.Click += new System.EventHandler(this.btnEmergencia_Click);
            // 
            // PersonalMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 551);
            this.Controls.Add(this.btnEmergencia);
            this.Controls.Add(this.btnCirugia);
            this.Controls.Add(this.btnHospitalizacion);
            this.Controls.Add(this.dgvPersonal);
            this.Controls.Add(this.btnInhabilitar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.txtLicencia);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.lblLicencia);
            this.Controls.Add(this.lblNombre);
            this.Name = "PersonalMedico";
            this.Text = "PersonalMedico";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblLicencia;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtLicencia;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.DataGridView dgvPersonal;
        private System.Windows.Forms.Button btnHospitalizacion;
        private System.Windows.Forms.Button btnCirugia;
        private System.Windows.Forms.Button btnEmergencia;
    }
}