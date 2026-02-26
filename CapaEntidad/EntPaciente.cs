using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntPaciente
    {
        public string NumeroOrden { get; set; }
        public string Dni { get; set; }
        public string Nombres { get; set; }
        public string ApelPaterno { get; set; }
        public string ApelMaterno { get; set; }
        public string Celular { get; set; }
        public int Edad { get; set; } // Propiedad original
        public string Traslado { get; set; } //
        public DateTime? FechaNacimiento { get; set; } //
        public string EdadDetallada { get; set; } // Nueva propiedad para "X años y Y meses"
    }
}
