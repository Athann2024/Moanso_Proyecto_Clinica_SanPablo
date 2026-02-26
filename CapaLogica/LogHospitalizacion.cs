using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad; 

namespace CapaLogica
{
    public class LogHospitalizacion
    {
        private static readonly LogHospitalizacion _instancia = new LogHospitalizacion();
        public static LogHospitalizacion Instancia => _instancia;

        private List<EntHospitalizacion> listaHospitalizaciones = new List<EntHospitalizacion>();

        public bool RegistrarReserva(EntHospitalizacion h)
        {
            // CAR-03: Validar disponibilidad antes de confirmar
            listaHospitalizaciones.Add(h);
            return true;
        }

        public List<EntHospitalizacion> ListarHospitalizaciones() => listaHospitalizaciones;
    }
}
