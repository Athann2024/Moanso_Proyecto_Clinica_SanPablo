using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntHospitalizacion
    {
        public string OrdenMedica { get; set; }
        public DateTime FechaProbable { get; set; } // Asegúrate que se llame así
        public string DniPaciente { get; set; }
        public string Especialidad { get; set; }
        public int NumeroCama { get; set; }
        public string Estado { get; set; }
    }
}
