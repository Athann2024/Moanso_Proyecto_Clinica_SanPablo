using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogEmergencia
    {
        // 1. Singleton correcto: apunta a LogEmergencia
        private static readonly LogEmergencia _instancia = new LogEmergencia();
        public static LogEmergencia Instancia => _instancia;

        // 2. Método para Listar (NEC-10): Llama a la Capa Datos
        public List<EntEmergencia> ListarAdmisiones()
        {
            return DatEmergencia.Instancia.ListarEmergencias();
        }

        // 3. Método para Registrar (NEC-01): Llama a la Capa Datos
        public bool RegistrarAdmision(EntEmergencia e)
        {
            return DatEmergencia.Instancia.InsertarEmergencia(e);
        }
    }
}
