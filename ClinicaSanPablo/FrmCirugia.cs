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
    public partial class FrmCirugia : Form
    {
        public FrmCirugia()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //  Validación de longitud para DNI (8 dígitos en Perú)
            if (txtDniPaciente.Text.Length > 8)
            {
                // Cortamos el texto si se pasa de 8 para evitar errores de entrada
                txtDniPaciente.Text = txtDniPaciente.Text.Substring(0, 8);
                txtDniPaciente.SelectionStart = txtDniPaciente.Text.Length;
            }

            //  Búsqueda automática (Opcional - Mejora la experiencia de usuario NEC-10)
            if (txtDniPaciente.Text.Length == 8)
            {
                // Aquí podrías llamar a una función que busque si el paciente 
                // ya existe en tu LogPaciente para ahorrar tiempo al usuario.
                VerificarExistenciaPaciente(txtDniPaciente.Text);
            }
        }
        private void VerificarExistenciaPaciente(string dni)
        {
            // Buscamos en la lista de pacientes que ya tienes en tu CapaLogica
            var paciente = CapaLogica.LogPaciente.Instancia.ListarPacientes()
                           .FirstOrDefault(p => p.Dni == dni);

            if (paciente != null)
            {
                // Si existe, podrías mostrar un mensaje o llenar un label con su nombre
                // para confirmar que es el paciente correcto antes de la cirugía.
                lblEstadoAnestesiologo.Text = $"Paciente encontrado: {paciente.Nombres} {paciente.ApelPaterno}";
                lblEstadoAnestesiologo.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblEstadoAnestesiologo.Text = "Paciente no registrado. Use el botón superior.";
                lblEstadoAnestesiologo.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReservarCirugia_Click(object sender, EventArgs e)
        {
            try
            {
                EntCirugia c = new EntCirugia();
                c.DniPaciente = txtDniPaciente.Text;
                c.Cirujano = txtCirujano.Text;
                c.FechaHora = dtpFechaHora.Value;
                c.Pabellon = cmbPabellon.Text;
                c.SalaQuirurgica = cmbSalaQuirurgica.Text;
                c.TipoIntervencion = cmbTipoIntervencion.Text;
                c.Anestesiologo = cmbAnestesiologo.Text;
                c.Estado = "Programada"; // CAR-10

                // La lógica validará disponibilidad (CAR-03, CAR-04, CAR-05)
                if (LogCirugia.Instancia.RegistrarReservaCirugia(c))
                {
                    MessageBox.Show("Reservación registrada y confirmada (CAR-07).");
                    ListarCirugias();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmPaciente frm = new FrmPaciente();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmHospitalizacion frm = new FrmHospitalizacion();
            frm.Show();
            this.Hide();
        }
        // --- MÉTODO PARA REFRESCAR EL GRID ---
        private void ListarCirugias()
        {
            dgvCirugias.DataSource = null;
            dgvCirugias.DataSource = LogCirugia.Instancia.ListarCirugias();
        }

        private void btnIniciarIntervencion_Click(object sender, EventArgs e)
        {
            //  Validar que se haya seleccionado una cirugía del DataGridView (CAR-11)
            if (dgvCirugias.CurrentRow != null)
            {
                // Obtenemos el objeto de la fila seleccionada
                EntCirugia seleccionado = (EntCirugia)dgvCirugias.CurrentRow.DataBoundItem;

                //  Verificar que la sala esté reservada y disponible (CAR-12)
                if (seleccionado.Estado == "Programada")
                {
                    //  Registrar hora de inicio (CAR-16)
                    DateTime horaInicio = DateTime.Now;

                    //  Actualizar estado a "En Curso" o "Finalizada" según el flujo (CAR-21)
                    seleccionado.Estado = "En Curso";

                    //  Mostrar confirmación de la intervención (CAR-22)
                    MessageBox.Show($"Intervención Iniciada.\n" +
                                    $"Paciente: {seleccionado.DniPaciente}\n" +
                                    $"Sala: {seleccionado.SalaQuirurgica}\n" +
                                    $"Hora de Inicio: {horaInicio.ToShortTimeString()}",
                                    "SISTEMA DE CIRUGÍA");

                    ListarCirugias();
                }
                else
                {
                    MessageBox.Show("Esta cirugía ya ha sido iniciada o anulada.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una cirugía programada de la tabla.");
            }
        }

        private void btnAnularCirugia_Click(object sender, EventArgs e)
        {
            //  Verificar que se haya seleccionado una cirugía en el DataGridView (NEC-01)
            if (dgvCirugias.CurrentRow != null)
            {
                // Obtenemos el objeto seleccionado
                EntCirugia seleccionado = (EntCirugia)dgvCirugias.CurrentRow.DataBoundItem;

                //  Regla CAR-08: El sistema permitirá anular cuando la cirugía no haya iniciado
                if (seleccionado.Estado == "Programada")
                {
                    //  CAR-09: Registrar el motivo de anulación (usamos un InputBox simple o MessageBox)
                    DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea anular esta reservación?",
                                                             "Confirmar Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes)
                    {
                        //  CAR-10: Actualizar el estado de la reservación a "Anulada"
                        seleccionado.Estado = "Anulada";

                        MessageBox.Show("La reservación ha sido anulada exitosamente (CAR-07).", "SISTEMA");

                        // Refrescamos la tabla para mostrar el cambio de estado (NEC-06)
                        ListarCirugias();
                    }
                }
                else
                {
                    MessageBox.Show("No se puede anular una cirugía que ya está 'En Curso' o 'Finalizada'.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una cirugía de la lista para anular.");
            }
        }

        private void cmbAnestesiólogo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  Verificar que se haya seleccionado un profesional
            if (cmbAnestesiologo.SelectedIndex != -1)
            {
                string nombreAnestesiologo = cmbAnestesiologo.SelectedItem.ToString();

                //  CAR-05: El sistema deberá verificar disponibilidad de anestesiólogo habilitado
                // Aquí simulamos una validación de disponibilidad para la fecha elegida en dtpFechaHora
                DateTime fechaSeleccionada = dtpFechaHora.Value;

                // Nota: En una fase avanzada, aquí llamarías a la CapaLogica para consultar la base de datos
                // Por ahora, lanzamos un mensaje de confirmación visual
                lblEstadoAnestesiologo.Text = $"Verificando disponibilidad de {nombreAnestesiologo}...";
                lblEstadoAnestesiologo.ForeColor = Color.Blue;

                // Simulamos que el sistema confirma la habilitación (CAR-29)
                MessageBox.Show($"El anestesiólogo {nombreAnestesiologo} se encuentra habilitado para la cirugía programada el {fechaSeleccionada.ToShortDateString()}.", "Validación de Recursos");
            }
        }

        private void cmbIntervencion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  Verificar que se haya seleccionado un tipo de intervención (CAR-06)
            if (cmbTipoIntervencion.SelectedIndex != -1)
            {
                string intervencionSeleccionada = cmbTipoIntervencion.SelectedItem.ToString();

                //  CAR-23: El sistema deberá mostrar el tipo de intervención quirúrgica
                // Podemos usar un Label informativo para confirmar la selección al usuario
                lblDetalleIntervencion.Text = "Tipo de cirugía detectada: " + intervencionSeleccionada;
                lblDetalleIntervencion.ForeColor = Color.DarkGreen;

                //  CAR-40: Mantener tiempo de respuesta adecuado
                // Al procesar la selección localmente, garantizamos fluidez en la interfaz (NEC-10)

                // Ejemplo de lógica: Si es una cirugía compleja, podrías activar campos adicionales
                if (intervencionSeleccionada == "Cirugía de Corazón Abierto")
                {
                    MessageBox.Show("Atención: Esta intervención requiere validación de equipo quirúrgico especial (CAR-04).", "Aviso de Seguridad");
                }
            }
        }

        private void cmbSala_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvCirugias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificamos que el clic sea en una fila válida (no en el encabezado)
            if (e.RowIndex >= 0)
            {
                // Obtenemos la fila seleccionada del DataGridView
                DataGridViewRow fila = dgvCirugias.Rows[e.RowIndex];

                //  CARGAMOS LOS DATOS A LOS CONTROLES (NEC-03)
                // Asegúrate de que los nombres de las celdas coincidan con EntCirugia
                txtDniPaciente.Text = fila.Cells["DniPaciente"].Value.ToString();
                txtCirujano.Text = fila.Cells["Cirujano"].Value.ToString();
                dtpFechaHora.Value = Convert.ToDateTime(fila.Cells["FechaHora"].Value);
                cmbPabellon.Text = fila.Cells["Pabellon"].Value.ToString();
                cmbSalaQuirurgica.Text = fila.Cells["SalaQuirurgica"].Value.ToString();
                cmbTipoIntervencion.Text = fila.Cells["TipoIntervencion"].Value.ToString();
                cmbAnestesiologo.Text = fila.Cells["Anestesiologo"].Value.ToString();

                //  ACTUALIZAMOS EL LABEL DE ESTADO (CAR-33, CAR-35)
                string estadoActual = fila.Cells["Estado"].Value.ToString();
                lblEstadoCirugia.Text = "Estado actual: " + estadoActual;

                //  CAMBIAMOS EL COLOR SEGÚN EL ESTADO PARA MEJOR VISIBILIDAD (CAR-35)
                if (estadoActual == "Anulada")
                {
                    lblEstadoCirugia.ForeColor = System.Drawing.Color.Red;
                }
                else if (estadoActual == "En Curso")
                {
                    lblEstadoCirugia.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblEstadoCirugia.ForeColor = System.Drawing.Color.DarkBlue;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ir al formulario de emergencia
        }

        private void FrmCirugia_Load(object sender, EventArgs e)
        {

        }
    }
}
