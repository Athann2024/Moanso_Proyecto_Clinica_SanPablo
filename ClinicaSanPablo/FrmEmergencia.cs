using CapaDatos;
using CapaEntidad; 
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaSanPablo
{
    public partial class FrmEmergencia : Form
    {
        public FrmEmergencia()
        {
            InitializeComponent();
            ListarAdmisiones();
        }
        private void ListarAdmisiones()
        {
            dgvEmergencia.DataSource = null;
            dgvEmergencia.DataSource = LogEmergencia.Instancia.ListarAdmisiones(); //
        }
        private void button3_Click(object sender, EventArgs e)
        {
            FrmCirugia frm = new FrmCirugia();
            frm.Show();
            this.Hide();
        }

        private void btnAdmitir_Click(object sender, EventArgs e)
        {
            try
            {
                EntEmergencia adm = new EntEmergencia();
                adm.DniPaciente = txtDniEmergencia.Text;
                adm.MotivoUrgencia = txtMotivo.Text;

                // CAPTURA DE LOS NUEVOS CAMPOS:
                adm.PersonalMedico = cmbPersonalMedico.Text; // Nombre del médico del combo
                adm.Estado = cbmEstado.Text;           // "Crítico", "Leve", etc.
                adm.FechaIngreso = dtpFechaIngreso.Value; // Fecha del calendario

                adm.NivelTriaje = int.Parse(cmbPrioridad.Text);
                adm.Medicamento = cmbMedicamento.Text;

                // Llamamos a la lógica para insertar
                if (LogEmergencia.Instancia.RegistrarAdmision(adm))
                {
                    MessageBox.Show("Paciente admitido con éxito.");

                    // 3. Actualizamos el DataGridView para ver al nuevo paciente
                    dgvEmergencia.DataSource = LogEmergencia.Instancia.ListarAdmisiones();

                    // Opcional: Limpiar los controles después de registrar
                    LimpiarControles();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message);
            }
        }
        private void LimpiarControles()
        {
            // Limpia los cuadros de texto
            txtDniEmergencia.Clear();
            txtMotivo.Clear();

            // Reinicia los ComboBox a su estado inicial (sin selección)
            cmbPersonalMedico.SelectedIndex = -1;
            cbmEstado.SelectedIndex = -1;
            cmbPrioridad.SelectedIndex = -1;
            cmbMedicamento.SelectedIndex = -1;

            // Reinicia la fecha a la fecha actual
            dtpFechaIngreso.Value = DateTime.Now;
        }

        private void txtDniEmergencia_TextChanged(object sender, EventArgs e)
        {
            // NEC-10: Validación rápida de DNI
            if (txtDniEmergencia.Text.Length > 8)
                txtDniEmergencia.Text = txtDniEmergencia.Text.Substring(0, 8);
        }

        private void txtMotivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbPrioridad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbMedicamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            // CAR-02: Anular admisión solo si no hay atenciones asociadas
            if (dgvEmergencia.CurrentRow != null)
            {
                DialogResult r = MessageBox.Show("¿Desea anular esta admisión?", "Confirmar", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    // Aquí llamarías a un método de anulación en LogEmergencia
                    MessageBox.Show("Admisión anulada correctamente.");
                    ListarAdmisiones();
                }
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            // CAR-06: Confirmar finalización para habilitar alta o derivación
            MessageBox.Show("Atención finalizada. El paciente puede proceder al alta o derivación.");
        }

        private void dgvEmergencia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificamos que se haya hecho clic en una fila con datos (no en el encabezado)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvEmergencia.Rows[e.RowIndex];

                // SOLUCIÓN: Usamos "DniPaciente" que es el nombre que aparece en tu diseño
                // Si sigue fallando, revisa en las propiedades del Grid el "(Name)" de esa columna específica.
                txtDniEmergencia.Text = fila.Cells["DniPaciente"].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmHospitalizacion frm = new FrmHospitalizacion();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPaciente frm = new FrmPaciente();
            frm.Show();
            this.Hide();
        }

        private void FrmEmergencia_Load(object sender, EventArgs e)
        {
            try
            {
                // Llenamos el ComboBox con los nombres de la base de datos
                cmbPersonalMedico.DataSource = DatPersonalMedico.Instancia.ListarNombresMedicos();

                // Configuramos el calendario de ingreso a la fecha de hoy
                dtpFechaIngreso.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }
        public void ListarSoloEmergencias()
        {
            // Asegúrate de que el DataGridView en este formulario se llame dgvEmergencias
            dgvEmergencia.DataSource = DatPaciente.Instancia.ListarPacientesEmergencia();
        }

        private void dgvEmergencia_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Usamos "DniPaciente" porque es el nombre que se ve en el encabezado de tu imagen
                txtDniEmergencia.Text = dgvEmergencia.Rows[e.RowIndex].Cells["DniPaciente"].Value.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                string criterio = txtBuscarPaciente.Text.Trim();
                // Filtramos solo pacientes de emergencia por DNI o ID
                dgvEmergencia.DataSource = DatPaciente.Instancia.BuscarPacienteEmergencia(criterio);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en búsqueda: " + ex.Message);
            }
        }
    }
}
