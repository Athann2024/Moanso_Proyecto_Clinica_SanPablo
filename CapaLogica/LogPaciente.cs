using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogPaciente
    {
        private static readonly LogPaciente _instancia = new LogPaciente();
        public static LogPaciente Instancia => _instancia;

        // Lista que simula la base de datos temporal
        private List<EntPaciente> listaPacientes = new List<EntPaciente>();

        public bool RegistrarPaciente(EntPaciente p)
        {
            if (string.IsNullOrEmpty(p.Dni) || p.Dni.Length != 8) return false;
            // Llamada correcta usando la instancia Singleton
            return DatPaciente.Instancia.InsertarPaciente(p);
        }

        public List<EntPaciente> ListarPacientes()
        {
            return DatPaciente.Instancia.ListarPacientes();
        }

        // --- PRÓXIMO PASO: Método para Editar ---
        public bool EditarPaciente(EntPaciente p)
        {
            // Busca al paciente por DNI
            var pacienteExistente = listaPacientes.Find(x => x.Dni == p.Dni);
            if (pacienteExistente != null)
            {
                pacienteExistente.Nombres = p.Nombres;
                pacienteExistente.ApelPaterno = p.ApelPaterno;
                pacienteExistente.ApelMaterno = p.ApelMaterno;
                pacienteExistente.Celular = p.Celular;
                pacienteExistente.FechaNacimiento = p.FechaNacimiento;
                return true;
            }
            return false;
        }
        public string GenerarSiguienteOrden()
        {
            // Obtenemos la cantidad actual de pacientes
            int siguienteNumero = listaPacientes.Count + 1;

            // Retornamos el número con formato 000 (001, 002, etc.)
            return siguienteNumero.ToString("D3");
        }
    }
}
