using System;
using System.Windows.Forms;

namespace ClinicaSanPablo
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Esto le dice al programa que inicie con tu formulario de pacientes
            Application.Run(new FrmPaciente());
        }
    }
}