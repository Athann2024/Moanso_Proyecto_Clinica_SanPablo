using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogCirugia
    {
        private static readonly LogCirugia _instancia = new LogCirugia();
        public static LogCirugia Instancia => _instancia;

        private List<EntCirugia> listaCirugias = new List<EntCirugia>();

        public bool RegistrarReservaCirugia(EntCirugia c)
        {
            // CAR-03: Validar disponibilidad de sala según fecha y hora
            // CAR-04 y CAR-05: Se validaría disponibilidad de equipo y anestesiólogo
            listaCirugias.Add(c);
            return true;
        }

        public List<EntCirugia> ListarCirugias() => listaCirugias;
    }
}
