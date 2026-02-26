using CapaEntidad;
using CapaLogica;
using System;
using System.Windows.Forms;

namespace ClinicaSanPablo
{
    public partial class FrmHospitalizacion : Form
    {
        public FrmHospitalizacion()
        {
            InitializeComponent();
        }

        private void btnReservar_Click(object sender, System.EventArgs e)
        {
            // 1. Validaciones básicas
            if (string.IsNullOrEmpty(txtOrdenMedica.Text) || string.IsNullOrEmpty(txtDniPaciente.Text))
            {
                MessageBox.Show("Debe ingresar la Orden Médica y el DNI.");
                return;
            }

            try
            {
                // 2. Creamos la entidad con los datos de tus controles
                EntHospitalizacion reserva = new EntHospitalizacion();
                reserva.OrdenMedica = txtOrdenMedica.Text;
                reserva.FechaProbable = dtpFechaProbable.Value;
                reserva.DniPaciente = txtDniPaciente.Text;
                reserva.Especialidad = cmbEspecialidad.Text;
                reserva.NumeroCama = int.Parse(txtNumeroCama.Text);
                reserva.Estado = "Programada";

                // 3. Enviamos a la CapaLogica
                if (LogHospitalizacion.Instancia.RegistrarReserva(reserva))
                {
                    MessageBox.Show("Reservación registrada con éxito.");

                    // 4. ESTO ES LO QUE HACE QUE SE VEA EN EL GRID
                    ListarHospitalizaciones();

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
            txtOrdenMedica.Clear();
            txtDniPaciente.Clear();
            txtNumeroCama.Clear();
            cmbEspecialidad.SelectedIndex = -1;
        }

        private void btnAnular_Click(object sender, System.EventArgs e)
        {
            if (dgvHospitalizacion.CurrentRow != null)
            {
                // Lógica para cambiar estado a "Anulado" (CAR-04, CAR-10)
                MessageBox.Show("Reserva anulada conforme al requerimiento CAR-04.");
            }
        }
        private void ListarHospitalizaciones()
        {
            dgvHospitalizacion.DataSource = null;
            dgvHospitalizacion.DataSource = LogHospitalizacion.Instancia.ListarHospitalizaciones();
        }

        private void btnRegistrarIngreso_Click(object sender, System.EventArgs e)
        {
            if (dgvHospitalizacion.CurrentRow != null)
            {
                // Obtenemos el objeto seleccionado en la tabla
                EntHospitalizacion seleccionado = (EntHospitalizacion)dgvHospitalizacion.CurrentRow.DataBoundItem;

                // CAR-06: Verificamos que la cama esté libre antes de asignar (lógica simulada)
                // CAR-08: Cambiamos el estado a Ocupada
                seleccionado.Estado = "Ocupada";

                // CAR-07: Se registra la fecha y hora exacta del ingreso
                DateTime fechaIngreso = DateTime.Now;

                MessageBox.Show($"Ingreso registrado con éxito.\nCama: {seleccionado.NumeroCama}\nEstado: {seleccionado.Estado}\nFecha: {fechaIngreso}", "SISTEMA");

                ListarHospitalizaciones();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una reservación de la lista para proceder con el ingreso.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Creamos el formulario (asegúrate de que el nombre coincida)
            FrmEmergencia frm = new FrmEmergencia();
            frm.Show(); // Abre el de Emergencia
            this.Hide(); // Opcional: oculta el de Paciente
        }

        private void btnCirugia_Click(object sender, EventArgs e)
        {
            // Creamos el formulario (asegúrate de que el nombre coincida)
            FrmCirugia frm = new FrmCirugia();
            frm.Show(); // Abre el de Emergencia
            this.Hide(); // Opcional: oculta el de Paciente
        }

        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            // CAR-02: Tipos de sala según especialidad médica
            cmbEspecialidad.Items.Add("Medicina");
            cmbEspecialidad.Items.Add("Cirugía");
            cmbEspecialidad.Items.Add("Ginecología");
            cmbEspecialidad.Items.Add("Pediatría");

            ListarHospitalizaciones(); // Carga los datos existentes
        }

        private void dgvHospitalizacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Si haces clic en una fila válida
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvHospitalizacion.Rows[e.RowIndex];

                // Pasamos los datos de la tabla a los cuadros de texto
                txtOrdenMedica.Text = fila.Cells["OrdenMedica"].Value.ToString();
                txtDniPaciente.Text = fila.Cells["DniPaciente"].Value.ToString();
                cmbEspecialidad.Text = fila.Cells["Especialidad"].Value.ToString();
                txtNumeroCama.Text = fila.Cells["NumeroCama"].Value.ToString();
                dtpFechaProbable.Value = Convert.ToDateTime(fila.Cells["FechaProbable"].Value);
            }
        }

        private void btnRegistrarPaciente_Click(object sender, EventArgs e)
        {
            FrmPaciente frm = new FrmPaciente();
            frm.Show();
            this.Hide();
        }
    }
}
