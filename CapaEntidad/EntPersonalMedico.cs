using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
public class EntPersonalMedico
    {
        public int IdMedico { get; set; }
        public string Nombre { get; set; }
        public string Licencia { get; set; }
        public string Especialidad { get; set; }
        public string Turno { get; set; }
        public bool Activo { get; set; } // Para inhabilitar
    }
}
