using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntCirugia
    {
        public string DniPaciente { get; set; } // CAR-01
        public DateTime FechaHora { get; set; } // CAR-01
        public string Pabellon { get; set; }    // CAR-02
        public string SalaQuirurgica { get; set; } // CAR-02
        public string TipoIntervencion { get; set; } // CAR-06
        public string Anestesiologo { get; set; } // CAR-05
        public string Estado { get; set; } // CAR-10 (Programada, Anulada)
        public string Cirujano { get; set; }
    }
}
