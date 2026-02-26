using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntEmergencia
    {
        // CAR-01: Admisión con DNI y Motivo
        public string DniPaciente { get; set; }
        public string MotivoUrgencia { get; set; }
        public DateTime FechaIngreso { get; set; }

        // NEC-09: Nivel de Triaje (1, 2, 3)
        public int NivelTriaje { get; set; }

        // NEC-05: Medicamentos
        public string Medicamento { get; set; }

        public string Estado { get; set; } 
        public string PersonalMedico { get; set; }
    }
}
