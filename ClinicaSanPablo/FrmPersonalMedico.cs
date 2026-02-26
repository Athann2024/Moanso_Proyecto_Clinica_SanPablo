using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;


namespace ClinicaSanPablo
{
    public partial class FrmPersonalMedico : Form
    {
        public FrmPersonalMedico()
        {
            InitializeComponent();
            ListarMedicos();
        }
        private void ListarMedicos()
        {
            // Debes crear LogPersonalMedico en tu CapaLogica
            dgvPersonal.DataSource = DatPersonalMedico.Instancia.ListarPersonal();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtNombre.Text = txtNombre.Text.ToUpper();
            txtNombre.SelectionStart = txtNombre.Text.Length;
        }

        private void txtLicencia_TextChanged(object sender, EventArgs e)
        {
            if (txtLicencia.Text.Length > 20) // Límite de la base de datos
                txtLicencia.Text = txtLicencia.Text.Substring(0, 20);
        }

        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbTurno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkActivo_CheckedChanged(object sender, EventArgs e)
        {
            chkActivo.Text = chkActivo.Checked ? "Médico Habilitado" : "Médico Inhabilitado";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                EntPersonalMedico m = new EntPersonalMedico();
                m.Nombre = txtNombre.Text.Trim();
                m.Licencia = txtLicencia.Text.Trim();
                m.Especialidad = cmbEspecialidad.Text;
                m.Turno = cmbTurno.Text;

                if (DatPersonalMedico.Instancia.InsertarMedico(m))
                {
                    MessageBox.Show("Médico registrado correctamente.");
                    ListarMedicos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validamos que se haya seleccionado un médico del Grid
                if (dgvPersonal.CurrentRow == null)
                {
                    MessageBox.Show("Por favor, seleccione un médico de la tabla.");
                    return;
                }

                EntPersonalMedico m = new EntPersonalMedico();
                // Obtenemos el ID oculto o seleccionado del Grid
                m.IdMedico = Convert.ToInt32(dgvPersonal.CurrentRow.Cells["IdMedico"].Value);
                m.Nombre = txtNombre.Text.Trim();
                m.Licencia = txtLicencia.Text.Trim();
                m.Especialidad = cmbEspecialidad.Text;
                m.Turno = cmbTurno.Text;
                m.Activo = chkActivo.Checked;

                // Llamamos a la Capa Datos (asegúrate de tener el using CapaDatos arriba)
                if (DatPersonalMedico.Instancia.ModificarMedico(m))
                {
                    MessageBox.Show("Datos actualizados correctamente.");
                    ListarMedicos(); // Refresca el Grid
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPersonal.CurrentRow != null)
                {
                    int id = Convert.ToInt32(dgvPersonal.CurrentRow.Cells["IdMedico"].Value);

                    DialogResult r = MessageBox.Show("¿Está seguro de inhabilitar a este médico?", "Confirmar", MessageBoxButtons.YesNo);
                    if (r == DialogResult.Yes)
                    {
                        if (DatPersonalMedico.Instancia.InhabilitarMedico(id))
                        {
                            MessageBox.Show("El personal médico ha sido inhabilitado.");
                            ListarMedicos(); // Refresca la tabla
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvPersonal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtNombre.Text = dgvPersonal.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                txtLicencia.Text = dgvPersonal.Rows[e.RowIndex].Cells["Licencia"].Value.ToString();
                cmbEspecialidad.Text = dgvPersonal.Rows[e.RowIndex].Cells["Especialidad"].Value.ToString();
                cmbTurno.Text = dgvPersonal.Rows[e.RowIndex].Cells["Turno"].Value.ToString();
                chkActivo.Checked = Convert.ToBoolean(dgvPersonal.Rows[e.RowIndex].Cells["Activo"].Value);
            }
        }

        private void btnHospitalizacion_Click(object sender, EventArgs e)
        {
            FrmHospitalizacion frm = new FrmHospitalizacion();
            frm.Show();
            this.Hide();
        }

        private void btnCirugia_Click(object sender, EventArgs e)
        {
            FrmCirugia frm = new FrmCirugia();
            frm.Show();
            this.Hide();
        }

        private void btnEmergencia_Click(object sender, EventArgs e)
        {
            FrmEmergencia frm = new FrmEmergencia();
            frm.Show();
            this.Hide();
        }
    }
}
