using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogPersonalMedico
    {
        private static readonly LogPersonalMedico _instancia = new LogPersonalMedico();
        public static LogPersonalMedico Instancia => _instancia;

        public bool RegistrarMedico(EntPersonalMedico m) => DatPersonalMedico.Instancia.InsertarMedico(m);
        public List<EntPersonalMedico> ListarPersonal() => DatPersonalMedico.Instancia.ListarPersonal();
    }
}
