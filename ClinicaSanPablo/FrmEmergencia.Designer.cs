namespace ClinicaSanPablo
{
    partial class FrmEmergencia
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
            this.lblDni = new System.Windows.Forms.Label();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.lblTriaje = new System.Windows.Forms.Label();
            this.lblMedicamento = new System.Windows.Forms.Label();
            this.txtDniEmergencia = new System.Windows.Forms.TextBox();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            this.cmbMedicamento = new System.Windows.Forms.ComboBox();
            this.btnAdmitir = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.dgvEmergencia = new System.Windows.Forms.DataGridView();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblPersonalMedico = new System.Windows.Forms.Label();
            this.cmbPersonalMedico = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbmEstado = new System.Windows.Forms.ComboBox();
            this.txtBuscarPaciente = new System.Windows.Forms.TextBox();
            this.lblBuscarPaciente = new System.Windows.Forms.Label();
            this.btnBuscarPaciente = new System.Windows.Forms.Button();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.DniPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MotivoUrgencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NivelTriaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonalMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmergencia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(421, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(151, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "PROCESO DE EMERGENCIA";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(21, 53);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(74, 13);
            this.lblDni.TabIndex = 1;
            this.lblDni.Text = "DNI Paciente:";
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(21, 102);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(103, 13);
            this.lblMotivo.TabIndex = 2;
            this.lblMotivo.Text = "Motivo de Urgencia:";
            // 
            // lblTriaje
            // 
            this.lblTriaje.AutoSize = true;
            this.lblTriaje.Location = new System.Drawing.Point(21, 236);
            this.lblTriaje.Name = "lblTriaje";
            this.lblTriaje.Size = new System.Drawing.Size(78, 13);
            this.lblTriaje.TabIndex = 3;
            this.lblTriaje.Text = "Nivel de Triaje:";
            // 
            // lblMedicamento
            // 
            this.lblMedicamento.AutoSize = true;
            this.lblMedicamento.Location = new System.Drawing.Point(21, 282);
            this.lblMedicamento.Name = "lblMedicamento";
            this.lblMedicamento.Size = new System.Drawing.Size(74, 13);
            this.lblMedicamento.TabIndex = 4;
            this.lblMedicamento.Text = "Medicamento:";
            // 
            // txtDniEmergencia
            // 
            this.txtDniEmergencia.Location = new System.Drawing.Point(24, 79);
            this.txtDniEmergencia.Name = "txtDniEmergencia";
            this.txtDniEmergencia.Size = new System.Drawing.Size(100, 20);
            this.txtDniEmergencia.TabIndex = 5;
            this.txtDniEmergencia.TextChanged += new System.EventHandler(this.txtDniEmergencia_TextChanged);
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(24, 118);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(100, 20);
            this.txtMotivo.TabIndex = 6;
            this.txtMotivo.TextChanged += new System.EventHandler(this.txtMotivo_TextChanged);
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.FormattingEnabled = true;
            this.cmbPrioridad.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbPrioridad.Location = new System.Drawing.Point(24, 258);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(153, 21);
            this.cmbPrioridad.TabIndex = 7;
            this.cmbPrioridad.SelectedIndexChanged += new System.EventHandler(this.cmbPrioridad_SelectedIndexChanged);
            // 
            // cmbMedicamento
            // 
            this.cmbMedicamento.FormattingEnabled = true;
            this.cmbMedicamento.Items.AddRange(new object[] {
            "Paracetamol 500mg (Pastilla)",
            "Ibuprofeno 400mg (Pastilla)",
            "Amoxicilina 500mg (Pastilla)",
            "Naproxeno 550mg (Pastilla)",
            "Loratadina 10mg (Pastilla)",
            "Aspirina 100mg (Pastilla)",
            "Omeprazol 20mg (Pastilla)",
            "Diazepam 5mg (Pastilla)",
            "Ambroxol (Jarabe)",
            "Clorfenamina (Jarabe)",
            "Panadol Niños (Jarabe)",
            "Mucosolvan (Jarabe)",
            "Antalgina (Jarabe)",
            "Bisolvon (Jarabe)",
            "Dexametasona (Inyección)",
            "Neurobion (Inyección)",
            "Ceftriaxona 1g (Inyección)",
            "Ketorolaco (Inyección)",
            "Metoclopramida (Inyección)",
            "Gentamicina (Inyección)"});
            this.cmbMedicamento.Location = new System.Drawing.Point(24, 298);
            this.cmbMedicamento.Name = "cmbMedicamento";
            this.cmbMedicamento.Size = new System.Drawing.Size(153, 21);
            this.cmbMedicamento.TabIndex = 8;
            this.cmbMedicamento.SelectedIndexChanged += new System.EventHandler(this.cmbMedicamento_SelectedIndexChanged);
            // 
            // btnAdmitir
            // 
            this.btnAdmitir.Location = new System.Drawing.Point(245, 479);
            this.btnAdmitir.Name = "btnAdmitir";
            this.btnAdmitir.Size = new System.Drawing.Size(110, 61);
            this.btnAdmitir.TabIndex = 9;
            this.btnAdmitir.Text = "Registrar Admisión";
            this.btnAdmitir.UseVisualStyleBackColor = true;
            this.btnAdmitir.Click += new System.EventHandler(this.btnAdmitir_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(361, 478);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(110, 60);
            this.btnAnular.TabIndex = 10;
            this.btnAnular.Text = "Anular Admisión";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // dgvEmergencia
            // 
            this.dgvEmergencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmergencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DniPaciente,
            this.MotivoUrgencia,
            this.FechaIngreso,
            this.NivelTriaje,
            this.Medicamento,
            this.Estado,
            this.PersonalMedico});
            this.dgvEmergencia.Location = new System.Drawing.Point(245, 53);
            this.dgvEmergencia.Name = "dgvEmergencia";
            this.dgvEmergencia.Size = new System.Drawing.Size(742, 421);
            this.dgvEmergencia.TabIndex = 11;
            this.dgvEmergencia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmergencia_CellContentClick);
            this.dgvEmergencia.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmergencia_CellContentDoubleClick);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(477, 479);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(110, 61);
            this.btnFinalizar.TabIndex = 12;
            this.btnFinalizar.Text = "Finalizar Atención";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(810, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "Registrar nuevo Paciente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(920, 586);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 30);
            this.button2.TabIndex = 14;
            this.button2.Text = "Hospitalizacion";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(920, 550);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 30);
            this.button3.TabIndex = 15;
            this.button3.Text = "Cirugia ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblPersonalMedico
            // 
            this.lblPersonalMedico.AutoSize = true;
            this.lblPersonalMedico.Location = new System.Drawing.Point(21, 151);
            this.lblPersonalMedico.Name = "lblPersonalMedico";
            this.lblPersonalMedico.Size = new System.Drawing.Size(86, 13);
            this.lblPersonalMedico.TabIndex = 16;
            this.lblPersonalMedico.Text = "Personal Medico";
            // 
            // cmbPersonalMedico
            // 
            this.cmbPersonalMedico.FormattingEnabled = true;
            this.cmbPersonalMedico.Location = new System.Drawing.Point(24, 167);
            this.cmbPersonalMedico.Name = "cmbPersonalMedico";
            this.cmbPersonalMedico.Size = new System.Drawing.Size(121, 21);
            this.cmbPersonalMedico.TabIndex = 17;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(21, 191);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(102, 13);
            this.lblEstado.TabIndex = 18;
            this.lblEstado.Text = "Estado del Paciente";
            // 
            // cbmEstado
            // 
            this.cbmEstado.FormattingEnabled = true;
            this.cbmEstado.Items.AddRange(new object[] {
            "Critico",
            "Leve",
            "Estable"});
            this.cbmEstado.Location = new System.Drawing.Point(21, 207);
            this.cbmEstado.Name = "cbmEstado";
            this.cbmEstado.Size = new System.Drawing.Size(113, 21);
            this.cbmEstado.TabIndex = 19;
            // 
            // txtBuscarPaciente
            // 
            this.txtBuscarPaciente.Location = new System.Drawing.Point(21, 433);
            this.txtBuscarPaciente.Name = "txtBuscarPaciente";
            this.txtBuscarPaciente.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarPaciente.TabIndex = 20;
            this.txtBuscarPaciente.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblBuscarPaciente
            // 
            this.lblBuscarPaciente.AutoSize = true;
            this.lblBuscarPaciente.Location = new System.Drawing.Point(21, 417);
            this.lblBuscarPaciente.Name = "lblBuscarPaciente";
            this.lblBuscarPaciente.Size = new System.Drawing.Size(85, 13);
            this.lblBuscarPaciente.TabIndex = 21;
            this.lblBuscarPaciente.Text = "Buscar Paciente";
            // 
            // btnBuscarPaciente
            // 
            this.btnBuscarPaciente.Location = new System.Drawing.Point(20, 459);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(104, 24);
            this.btnBuscarPaciente.TabIndex = 22;
            this.btnBuscarPaciente.Text = "Buscar Paciente";
            this.btnBuscarPaciente.UseVisualStyleBackColor = true;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click);
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Location = new System.Drawing.Point(24, 372);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaIngreso.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Fecha de Ingreso";
            // 
            // DniPaciente
            // 
            this.DniPaciente.DataPropertyName = "DniPaciente";
            this.DniPaciente.HeaderText = "DNI Paciente";
            this.DniPaciente.Name = "DniPaciente";
            // 
            // MotivoUrgencia
            // 
            this.MotivoUrgencia.DataPropertyName = "MotivoUrgencia";
            this.MotivoUrgencia.HeaderText = "Motivo de Urgencia";
            this.MotivoUrgencia.Name = "MotivoUrgencia";
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.DataPropertyName = "FechaIngreso";
            this.FechaIngreso.HeaderText = "Fecha Ingreso";
            this.FechaIngreso.Name = "FechaIngreso";
            // 
            // NivelTriaje
            // 
            this.NivelTriaje.DataPropertyName = "NivelTriaje";
            this.NivelTriaje.HeaderText = "Nivel de Triaje";
            this.NivelTriaje.Name = "NivelTriaje";
            // 
            // Medicamento
            // 
            this.Medicamento.DataPropertyName = "Medicamento";
            this.Medicamento.HeaderText = "Medicamento";
            this.Medicamento.Name = "Medicamento";
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // PersonalMedico
            // 
            this.PersonalMedico.DataPropertyName = "PersonalMedico";
            this.PersonalMedico.HeaderText = "Personal Médico";
            this.PersonalMedico.Name = "PersonalMedico";
            // 
            // FrmEmergencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 653);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.btnBuscarPaciente);
            this.Controls.Add(this.lblBuscarPaciente);
            this.Controls.Add(this.txtBuscarPaciente);
            this.Controls.Add(this.cbmEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cmbPersonalMedico);
            this.Controls.Add(this.lblPersonalMedico);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.dgvEmergencia);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnAdmitir);
            this.Controls.Add(this.cmbMedicamento);
            this.Controls.Add(this.cmbPrioridad);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.txtDniEmergencia);
            this.Controls.Add(this.lblMedicamento);
            this.Controls.Add(this.lblTriaje);
            this.Controls.Add(this.lblMotivo);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmEmergencia";
            this.Text = "FrmEmergencia";
            this.Load += new System.EventHandler(this.FrmEmergencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmergencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.Label lblTriaje;
        private System.Windows.Forms.Label lblMedicamento;
        private System.Windows.Forms.TextBox txtDniEmergencia;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.ComboBox cmbPrioridad;
        private System.Windows.Forms.ComboBox cmbMedicamento;
        private System.Windows.Forms.Button btnAdmitir;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.DataGridView dgvEmergencia;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblPersonalMedico;
        private System.Windows.Forms.ComboBox cmbPersonalMedico;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cbmEstado;
        private System.Windows.Forms.TextBox txtBuscarPaciente;
        private System.Windows.Forms.Label lblBuscarPaciente;
        private System.Windows.Forms.Button btnBuscarPaciente;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DniPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn MotivoUrgencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn NivelTriaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonalMedico;
    }
}