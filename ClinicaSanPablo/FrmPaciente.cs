using CapaDatos;
using CapaEntidad;
using CapaLogica;
using System;
using System.Windows.Forms;

namespace ClinicaSanPablo
{
    public partial class FrmPaciente : Form
    {
        public FrmPaciente()
        {
            InitializeComponent();
            // Cambia el nombre al de tu DataGridView real
            dgvPacientes.DataSource = LogPaciente.Instancia.ListarPacientes();
        }
        public void CargarPacientesDesdeSQL()
        {
            dgvPacientes.DataSource = null;
            dgvPacientes.DataSource = LogPaciente.Instancia.ListarPacientes();
        }
        // --- MÉTODO PARA REFRESCAR EL DATAGRIDVIEW ---

        private void dtpFechaNac_ValueChanged(object sender, System.EventArgs e)
        {
            DateTime fechaNac = dtpFechaNac.Value;
            DateTime hoy = DateTime.Today;

            // Cálculo de años
            int edadAnios = hoy.Year - fechaNac.Year;
            if (fechaNac.Date > hoy.AddYears(-edadAnios)) edadAnios--;

            // Cálculo de meses para el label detallado
            int meses = hoy.Month - fechaNac.Month;
            if (hoy.Day < fechaNac.Day) meses--;
            if (meses < 0) meses += 12;

            // Actualizamos el label visual
            lblEdadCalculada.Text = $"{edadAnios} años y {meses} meses";
        }

        private void FrmPaciente_Load(object sender, EventArgs e)
        {
            txtNumOrden.Text = LogPaciente.Instancia.GenerarSiguienteOrden();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                EntPaciente p = new EntPaciente();
                p.Dni = txtDni.Text;
                p.Nombres = txtNombre.Text;
                p.ApelPaterno = txtApelPaterno.Text;
                p.ApelMaterno = txtApelMaterno.Text;
                p.Celular = txtCelular.Text;
                p.Traslado = cmbTraslado.Text;

                // FUNCIÓN 1: Guardar la fecha exacta
                p.FechaNacimiento = dtpFechaNac.Value;

                // FUNCIÓN 2: Guardar la edad calculada (entero)
                int edad = DateTime.Today.Year - dtpFechaNac.Value.Year;
                if (dtpFechaNac.Value.Date > DateTime.Today.AddYears(-edad)) edad--;
                p.Edad = edad;

                // Enviamos a la Capa Datos (asegúrate de que DatPaciente reciba @Tra y @Fec)
                if (DatPaciente.Instancia.InsertarPaciente(p))
                {
                    MessageBox.Show("Paciente registrado correctamente con edad: " + edad);
                    ListarPacientes(); // Refresca el Grid para mostrar las 2 funciones
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }
        private void LimpiarControles()
        {
            txtDni.Clear();
            txtNombre.Clear();
            txtApelPaterno.Clear();
            txtApelMaterno.Clear();
            txtCelular.Clear();
            dtpFechaNac.Value = DateTime.Now;
            // El foco vuelve al DNI para el siguiente registro
            txtDni.Focus();
        }
        public void ListarPacientes()
        {
            dgvPacientes.DataSource = null;
            dgvPacientes.DataSource = LogPaciente.Instancia.ListarPacientes();
        }

        private void btnIrEmergencia_Click(object sender, EventArgs e)
        {
            // Creamos el formulario (asegúrate de que el nombre coincida)
            FrmEmergencia frm = new FrmEmergencia();
            frm.Show(); // Abre el de Emergencia
            this.Hide(); // Opcional: oculta el de Paciente
        }

        private void btnIrHospitalizacion_Click(object sender, EventArgs e)
        {
            // Creamos el formulario (asegúrate de que el nombre coincida)
            FrmHospitalizacion frm = new FrmHospitalizacion();
            frm.Show(); // Abre el de Emergencia
            this.Hide(); // Opcional: oculta el de Paciente
        }

        private void btnIrCirugia_Click(object sender, EventArgs e)
        {
            // Creamos el formulario (asegúrate de que el nombre coincida)
            FrmCirugia frm = new FrmCirugia();
            frm.Show(); // Abre el de Emergencia
            this.Hide(); // Opcional: oculta el de Paciente
        }

        private void btnPersonalMedico_Click(object sender, EventArgs e)
        {
            // Creamos el formulario (asegúrate de que el nombre coincida)
            FrmPersonalMedico frm = new FrmPersonalMedico();
            frm.Show(); // Abre el de Emergencia
            this.Hide(); // Opcional: oculta el de Paciente
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                EntPaciente p = new EntPaciente();
                p.Dni = txtDni.Text;
                p.Nombres = txtNombre.Text;
                p.ApelPaterno = txtApelPaterno.Text;
                p.ApelMaterno = txtApelMaterno.Text;
                p.Celular = txtCelular.Text;
                p.Traslado = cmbTraslado.Text; // Nueva columna

                if (DatPaciente.Instancia.ModificarPaciente(p))
                {
                    MessageBox.Show("Paciente actualizado con éxito.");
                    ListarPacientes(); // Refresca el Grid
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validamos que el DNI no esté vacío
                if (string.IsNullOrEmpty(txtDni.Text))
                {
                    MessageBox.Show("Seleccione un paciente con doble clic antes de editar.");
                    return;
                }

                EntPaciente p = new EntPaciente();
                p.Dni = txtDni.Text;
                p.Nombres = txtNombre.Text.Trim();
                p.ApelPaterno = txtApelPaterno.Text.Trim();
                p.ApelMaterno = txtApelMaterno.Text.Trim();
                p.Celular = txtCelular.Text.Trim();
                p.Traslado = cmbTraslado.Text; // NEC-10
                p.FechaNacimiento = dtpFechaNac.Value; //

                // Llamamos al método que ya tienes en DatPaciente
                if (DatPaciente.Instancia.ModificarPaciente(p))
                {
                    MessageBox.Show("Registro actualizado correctamente.");
                    ListarPacientes(); // Refresca el Grid
                    txtDni.ReadOnly = false; // Liberamos el campo para nuevos registros
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Usamos dgvPacientes para que coincida con tu diseño
                DataGridViewRow fila = dgvPacientes.Rows[e.RowIndex];

                // Autocompletado con validación de nulos (evita errores si hay celdas vacías)
                txtDni.Text = fila.Cells["Dni"].Value?.ToString() ?? "";
                txtNombre.Text = fila.Cells["Nombres"].Value?.ToString() ?? "";
                txtApelPaterno.Text = fila.Cells["ApelPaterno"].Value?.ToString() ?? "";
                txtApelMaterno.Text = fila.Cells["ApelMaterno"].Value?.ToString() ?? "";
                txtCelular.Text = fila.Cells["Celular"].Value?.ToString() ?? "";

                // Manejo seguro de la Fecha de Nacimiento
                object cellVal = fila.Cells["FechaNacimiento"].Value;
                if (cellVal != null && cellVal != DBNull.Value)
                {
                    DateTime fecha = Convert.ToDateTime(cellVal);
                    // El valor debe estar entre el rango Min y Max del control
                    if (fecha >= dtpFechaNac.MinDate && fecha <= dtpFechaNac.MaxDate)
                        dtpFechaNac.Value = fecha;
                    else
                        dtpFechaNac.Value = DateTime.Now;
                }
                else
                {
                    dtpFechaNac.Value = DateTime.Now;
                }

                // Manejo del Traslado (NEC-10)
                cmbTraslado.Text = fila.Cells["Traslado"].Value?.ToString() ?? "Ninguno";

                // Bloqueo de DNI para proteger la llave primaria en la edición
                txtDni.ReadOnly = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string criterio = txtBusqueda.Text.Trim(); // El TextBox debajo de 'BuscarPaciente'
                string traslado = cmbTraslado.Text; // El ComboBox 'Traslado a:'

                // Llamamos a la capa datos con ambos parámetros
                var resultados = DatPaciente.Instancia.BuscarPacientes(criterio, traslado);
                dgvPacientes.DataSource = resultados;

                if (resultados.Count == 0)
                {
                    MessageBox.Show("No se encontraron pacientes con esos criterios.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private void txtNumOrden_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {

        }
        private string CalcularEdadDetallada(DateTime fechaNacimiento)
        {
            DateTime hoy = DateTime.Today;
            int años = hoy.Year - fechaNacimiento.Year;
            int meses = hoy.Month - fechaNacimiento.Month;

            if (hoy.Day < fechaNacimiento.Day)
            {
                meses--;
            }

            if (meses < 0)
            {
                años--;
                meses += 12;
            }

            return $"{años} años, {meses} meses";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblEdadCalculada.Text = CalcularEdadDetallada(dtpFechaNac.Value);
        }

        private void btnMostrarPaciente_Click(object sender, EventArgs e)
        {
            txtBusqueda.Clear();
            cmbTraslado.SelectedIndex = -1;
            dgvPacientes.DataSource = LogPaciente.Instancia.ListarPacientes();
        }
    }

}
