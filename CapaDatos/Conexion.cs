using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conexion
    {
        private static readonly Conexion _instancia = new Conexion();
        public static Conexion Instancia => _instancia;

        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection();
            // Reemplaza '.' por el nombre de tu servidor SQL si es diferente
            cn.ConnectionString = "Data Source=FABRICIO\\SQLEXPRESS01; Initial Catalog=ClinicaSanPablo; Integrated Security=True";
            return cn;
        }
    }
}
