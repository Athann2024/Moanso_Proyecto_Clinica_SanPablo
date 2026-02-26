namespace ClinicaSanPablo
{
    partial class FrmCirugia
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
            this.txtDniPaciente = new System.Windows.Forms.TextBox();
            this.dtpFechaHora = new System.Windows.Forms.DateTimePicker();
            this.cmbPabellon = new System.Windows.Forms.ComboBox();
            this.cmbSalaQuirurgica = new System.Windows.Forms.ComboBox();
            this.btnReservarCirugia = new System.Windows.Forms.Button();
            this.btnAnularCirugia = new System.Windows.Forms.Button();
            this.dgvCirugias = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDniPaciente = new System.Windows.Forms.Label();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.lblPabellon = new System.Windows.Forms.Label();
            this.lblSala = new System.Windows.Forms.Label();
            this.lblDetalleIntervencion = new System.Windows.Forms.Label();
            this.cmbTipoIntervencion = new System.Windows.Forms.ComboBox();
            this.lblEstadoAnestesiologo = new System.Windows.Forms.Label();
            this.cmbAnestesiologo = new System.Windows.Forms.ComboBox();
            this.btnIniciarIntervencion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblEstadoCirugia = new System.Windows.Forms.Label();
            this.lblCirujano = new System.Windows.Forms.Label();
            this.txtCirujano = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCirugias)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDniPaciente
            // 
            this.txtDniPaciente.Location = new System.Drawing.Point(12, 65);
            this.txtDniPaciente.Name = "txtDniPaciente";
            this.txtDniPaciente.Size = new System.Drawing.Size(100, 20);
            this.txtDniPaciente.TabIndex = 0;
            this.txtDniPaciente.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dtpFechaHora
            // 
            this.dtpFechaHora.Location = new System.Drawing.Point(12, 127);
            this.dtpFechaHora.Name = "dtpFechaHora";
            this.dtpFechaHora.Size = new System.Drawing.Size(212, 20);
            this.dtpFechaHora.TabIndex = 1;
            // 
            // cmbPabellon
            // 
            this.cmbPabellon.FormattingEnabled = true;
            this.cmbPabellon.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cmbPabellon.Location = new System.Drawing.Point(12, 232);
            this.cmbPabellon.Name = "cmbPabellon";
            this.cmbPabellon.Size = new System.Drawing.Size(121, 21);
            this.cmbPabellon.TabIndex = 2;
            // 
            // cmbSalaQuirurgica
            // 
            this.cmbSalaQuirurgica.FormattingEnabled = true;
            this.cmbSalaQuirurgica.Items.AddRange(new object[] {
            "Sala 01",
            "Sala 02",
            "Sala 03",
            "Sala 04",
            "Sala 05",
            "Sala 06",
            "Sala 07",
            "Sala 08",
            "Sala 09",
            "Sala 10",
            "Sala 11",
            "Sala 12",
            "Sala 13",
            "Sala 14",
            "Sala 15",
            "Sala 16",
            "Sala 17",
            "Sala 18",
            "Sala 19",
            "Sala 20"});
            this.cmbSalaQuirurgica.Location = new System.Drawing.Point(12, 286);
            this.cmbSalaQuirurgica.Name = "cmbSalaQuirurgica";
            this.cmbSalaQuirurgica.Size = new System.Drawing.Size(121, 21);
            this.cmbSalaQuirurgica.TabIndex = 3;
            this.cmbSalaQuirurgica.SelectedIndexChanged += new System.EventHandler(this.cmbSala_SelectedIndexChanged);
            // 
            // btnReservarCirugia
            // 
            this.btnReservarCirugia.Location = new System.Drawing.Point(131, 515);
            this.btnReservarCirugia.Name = "btnReservarCirugia";
            this.btnReservarCirugia.Size = new System.Drawing.Size(122, 49);
            this.btnReservarCirugia.TabIndex = 4;
            this.btnReservarCirugia.Text = "Registrar Reserva";
            this.btnReservarCirugia.UseVisualStyleBackColor = true;
            this.btnReservarCirugia.Click += new System.EventHandler(this.btnReservarCirugia_Click);
            // 
            // btnAnularCirugia
            // 
            this.btnAnularCirugia.Location = new System.Drawing.Point(271, 515);
            this.btnAnularCirugia.Name = "btnAnularCirugia";
            this.btnAnularCirugia.Size = new System.Drawing.Size(122, 49);
            this.btnAnularCirugia.TabIndex = 5;
            this.btnAnularCirugia.Text = "Anular Reserva";
            this.btnAnularCirugia.UseVisualStyleBackColor = true;
            this.btnAnularCirugia.Click += new System.EventHandler(this.btnAnularCirugia_Click);
            // 
            // dgvCirugias
            // 
            this.dgvCirugias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCirugias.Location = new System.Drawing.Point(242, 56);
            this.dgvCirugias.Name = "dgvCirugias";
            this.dgvCirugias.Size = new System.Drawing.Size(712, 326);
            this.dgvCirugias.TabIndex = 6;
            this.dgvCirugias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCirugias_CellContentClick);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(269, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(124, 13);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "PROCESO DE CIRUGÍA";
            // 
            // lblDniPaciente
            // 
            this.lblDniPaciente.AutoSize = true;
            this.lblDniPaciente.Location = new System.Drawing.Point(9, 49);
            this.lblDniPaciente.Name = "lblDniPaciente";
            this.lblDniPaciente.Size = new System.Drawing.Size(74, 13);
            this.lblDniPaciente.TabIndex = 8;
            this.lblDniPaciente.Text = "DNI Paciente:";
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Location = new System.Drawing.Point(12, 101);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(111, 13);
            this.lblFechaHora.TabIndex = 9;
            this.lblFechaHora.Text = "Fecha y Hora Cirugía:";
            // 
            // lblPabellon
            // 
            this.lblPabellon.AutoSize = true;
            this.lblPabellon.Location = new System.Drawing.Point(12, 216);
            this.lblPabellon.Name = "lblPabellon";
            this.lblPabellon.Size = new System.Drawing.Size(51, 13);
            this.lblPabellon.TabIndex = 10;
            this.lblPabellon.Text = "Pabellón:";
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Location = new System.Drawing.Point(12, 256);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(82, 13);
            this.lblSala.TabIndex = 11;
            this.lblSala.Text = "Sala Quirúrgica:";
            // 
            // lblDetalleIntervencion
            // 
            this.lblDetalleIntervencion.AutoSize = true;
            this.lblDetalleIntervencion.Location = new System.Drawing.Point(9, 320);
            this.lblDetalleIntervencion.Name = "lblDetalleIntervencion";
            this.lblDetalleIntervencion.Size = new System.Drawing.Size(108, 13);
            this.lblDetalleIntervencion.TabIndex = 12;
            this.lblDetalleIntervencion.Text = "Tipo de Intervención:";
            this.lblDetalleIntervencion.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbTipoIntervencion
            // 
            this.cmbTipoIntervencion.FormattingEnabled = true;
            this.cmbTipoIntervencion.Items.AddRange(new object[] {
            "Cirugía de ",
            "Cirugía de ",
            "Cirugía de",
            "Cirugía de",
            "Cirugía de",
            "Cirugía de",
            "Cirugía de",
            "Cirugía de"});
            this.cmbTipoIntervencion.Location = new System.Drawing.Point(12, 346);
            this.cmbTipoIntervencion.Name = "cmbTipoIntervencion";
            this.cmbTipoIntervencion.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoIntervencion.TabIndex = 13;
            this.cmbTipoIntervencion.SelectedIndexChanged += new System.EventHandler(this.cmbIntervencion_SelectedIndexChanged);
            // 
            // lblEstadoAnestesiologo
            // 
            this.lblEstadoAnestesiologo.AutoSize = true;
            this.lblEstadoAnestesiologo.Location = new System.Drawing.Point(12, 393);
            this.lblEstadoAnestesiologo.Name = "lblEstadoAnestesiologo";
            this.lblEstadoAnestesiologo.Size = new System.Drawing.Size(76, 13);
            this.lblEstadoAnestesiologo.TabIndex = 14;
            this.lblEstadoAnestesiologo.Text = "Anestesiólogo:";
            // 
            // cmbAnestesiologo
            // 
            this.cmbAnestesiologo.FormattingEnabled = true;
            this.cmbAnestesiologo.Items.AddRange(new object[] {
            "Dr. Ricardo Palma",
            "Dr. Ricardo Palma 1",
            "Dr. Ricardo Palma 2 ",
            "Dr. Ricardo Palma 3 ",
            "Dr. Ricardo Palma 4 ",
            "Dr. Ricardo Palma 5"});
            this.cmbAnestesiologo.Location = new System.Drawing.Point(12, 409);
            this.cmbAnestesiologo.Name = "cmbAnestesiologo";
            this.cmbAnestesiologo.Size = new System.Drawing.Size(121, 21);
            this.cmbAnestesiologo.TabIndex = 15;
            this.cmbAnestesiologo.SelectedIndexChanged += new System.EventHandler(this.cmbAnestesiólogo_SelectedIndexChanged);
            // 
            // btnIniciarIntervencion
            // 
            this.btnIniciarIntervencion.Location = new System.Drawing.Point(3, 515);
            this.btnIniciarIntervencion.Name = "btnIniciarIntervencion";
            this.btnIniciarIntervencion.Size = new System.Drawing.Size(122, 49);
            this.btnIniciarIntervencion.TabIndex = 16;
            this.btnIniciarIntervencion.Text = "Iniciar Intervención";
            this.btnIniciarIntervencion.UseVisualStyleBackColor = true;
            this.btnIniciarIntervencion.Click += new System.EventHandler(this.btnIniciarIntervencion_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(844, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 49);
            this.button1.TabIndex = 17;
            this.button1.Text = "Emergencia";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(844, 490);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 49);
            this.button2.TabIndex = 18;
            this.button2.Text = "Hospitalizacion ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(813, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 43);
            this.button3.TabIndex = 19;
            this.button3.Text = "Registrar nuevo paciente";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblEstadoCirugia
            // 
            this.lblEstadoCirugia.AutoSize = true;
            this.lblEstadoCirugia.Location = new System.Drawing.Point(12, 380);
            this.lblEstadoCirugia.Name = "lblEstadoCirugia";
            this.lblEstadoCirugia.Size = new System.Drawing.Size(10, 13);
            this.lblEstadoCirugia.TabIndex = 20;
            this.lblEstadoCirugia.Text = "-";
            // 
            // lblCirujano
            // 
            this.lblCirujano.AutoSize = true;
            this.lblCirujano.Location = new System.Drawing.Point(12, 161);
            this.lblCirujano.Name = "lblCirujano";
            this.lblCirujano.Size = new System.Drawing.Size(51, 13);
            this.lblCirujano.TabIndex = 21;
            this.lblCirujano.Text = "Cirujano :";
            // 
            // txtCirujano
            // 
            this.txtCirujano.Location = new System.Drawing.Point(12, 177);
            this.txtCirujano.Name = "txtCirujano";
            this.txtCirujano.Size = new System.Drawing.Size(100, 20);
            this.txtCirujano.TabIndex = 22;
            // 
            // FrmCirugia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 577);
            this.Controls.Add(this.txtCirujano);
            this.Controls.Add(this.lblCirujano);
            this.Controls.Add(this.lblEstadoCirugia);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIniciarIntervencion);
            this.Controls.Add(this.cmbAnestesiologo);
            this.Controls.Add(this.lblEstadoAnestesiologo);
            this.Controls.Add(this.cmbTipoIntervencion);
            this.Controls.Add(this.lblDetalleIntervencion);
            this.Controls.Add(this.lblSala);
            this.Controls.Add(this.lblPabellon);
            this.Controls.Add(this.lblFechaHora);
            this.Controls.Add(this.lblDniPaciente);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvCirugias);
            this.Controls.Add(this.btnAnularCirugia);
            this.Controls.Add(this.btnReservarCirugia);
            this.Controls.Add(this.cmbSalaQuirurgica);
            this.Controls.Add(this.cmbPabellon);
            this.Controls.Add(this.dtpFechaHora);
            this.Controls.Add(this.txtDniPaciente);
            this.Name = "FrmCirugia";
            this.Text = "FrmCirugia";
            this.Load += new System.EventHandler(this.FrmCirugia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCirugias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDniPaciente;
        private System.Windows.Forms.DateTimePicker dtpFechaHora;
        private System.Windows.Forms.ComboBox cmbPabellon;
        private System.Windows.Forms.ComboBox cmbSalaQuirurgica;
        private System.Windows.Forms.Button btnReservarCirugia;
        private System.Windows.Forms.Button btnAnularCirugia;
        private System.Windows.Forms.DataGridView dgvCirugias;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDniPaciente;
        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.Label lblPabellon;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.Label lblDetalleIntervencion;
        private System.Windows.Forms.ComboBox cmbTipoIntervencion;
        private System.Windows.Forms.Label lblEstadoAnestesiologo;
        private System.Windows.Forms.ComboBox cmbAnestesiologo;
        private System.Windows.Forms.Button btnIniciarIntervencion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblEstadoCirugia;
        private System.Windows.Forms.Label lblCirujano;
        private System.Windows.Forms.TextBox txtCirujano;
    }
}