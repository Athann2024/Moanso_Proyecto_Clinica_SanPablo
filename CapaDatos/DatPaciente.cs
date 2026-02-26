using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatPaciente
    {
        private static readonly DatPaciente _instancia = new DatPaciente();
        public static DatPaciente Instancia => _instancia;

        // 1. MÉTODO PARA REGISTRAR (Insertar)
        public bool InsertarPaciente(EntPaciente p)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_RegistrarPaciente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Dni", p.Dni);
                cmd.Parameters.AddWithValue("@Nom", p.Nombres);
                cmd.Parameters.AddWithValue("@Pat", p.ApelPaterno);
                cmd.Parameters.AddWithValue("@Mat", p.ApelMaterno);
                cmd.Parameters.AddWithValue("@Cel", p.Celular);
                cmd.Parameters.AddWithValue("@Edad", p.Edad);
                // SOLUCIÓN AL ERROR: Agregamos Traslado y Fecha
                cmd.Parameters.AddWithValue("@Tra", p.Traslado);
                cmd.Parameters.AddWithValue("@Fec", p.FechaNacimiento);

                cn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception e) { throw e; }
            finally { if (cmd != null) cmd.Connection.Close(); }
        }

        // 2. MÉTODO PARA EDITAR (Modificar - Soluciona Error CS1061)
        public bool ModificarPaciente(EntPaciente p)
        {
            SqlCommand cmd = null;
            bool modificado = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                // Asegúrate de que este Procedure exista en tu SQL Server
                cmd = new SqlCommand("sp_ModificarPaciente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Dni", p.Dni);
                cmd.Parameters.AddWithValue("@Nom", p.Nombres);
                cmd.Parameters.AddWithValue("@Pat", p.ApelPaterno);
                cmd.Parameters.AddWithValue("@Mat", p.ApelMaterno);
                cmd.Parameters.AddWithValue("@Cel", p.Celular);
                cmd.Parameters.AddWithValue("@Tra", p.Traslado); // Nueva columna solicitada
                cn.Open();
                if (cmd.ExecuteNonQuery() > 0) modificado = true;
            }
            catch (Exception e) { throw e; }
            finally { if (cmd != null) cmd.Connection.Close(); }
            return modificado;
        }

        // 3. MÉTODO PARA LISTAR (Visualizar en Grid)
        public List<EntPaciente> ListarPacientes()
        {
            var lista = new List<EntPaciente>();
            // Mantenemos todas las columnas: NumeroOrden, Edad, Traslado y FechaNacimiento
            string query = @"
SELECT ROW_NUMBER() OVER (ORDER BY Dni) AS NumeroOrden,
       Dni, Nombres, ApelPaterno, ApelMaterno, Celular, Edad, Traslado, FechaNacimiento
FROM Paciente";

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                try
                {
                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            // 1. Manejo seguro de la fecha
                            DateTime? fechaNac = dr["FechaNacimiento"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["FechaNacimiento"]);

                            // 2. Creamos la entidad sin perder datos previos
                            EntPaciente p = new EntPaciente();

                            if (HasColumn(dr, "NumeroOrden") && dr["NumeroOrden"] != DBNull.Value)
                                p.NumeroOrden = Convert.ToInt32(dr["NumeroOrden"]).ToString("D3");
                            else
                                p.NumeroOrden = "000";

                            p.Dni = dr["Dni"].ToString();
                            p.Nombres = dr["Nombres"].ToString();
                            p.ApelPaterno = dr["ApelPaterno"].ToString();
                            p.ApelMaterno = dr["ApelMaterno"].ToString();
                            p.Celular = dr["Celular"].ToString();
                            p.Edad = Convert.ToInt32(dr["Edad"]); // Mantenemos la edad original
                            p.Traslado = dr["Traslado"].ToString(); // Mantenemos el traslado
                            p.FechaNacimiento = fechaNac;

                            // 3. Cálculo de Años y Meses (Si la fecha no es nula)
                            if (fechaNac.HasValue)
                            {
                                p.EdadDetallada = CalcularEdadDetallada(fechaNac.Value);
                            }
                            else
                            {
                                p.EdadDetallada = "Sin fecha";
                            }

                            lista.Add(p);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en base de datos: " + ex.Message, ex);
                }
            }
            return lista;
        }
        public List<EntPaciente> BuscarPacientes(string criterio, string traslado)
        {
            List<EntPaciente> lista = new List<EntPaciente>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();

                // CORRECCIÓN: Usamos IdPaciente y CAST para permitir el uso de LIKE
                string query = "SELECT * FROM Paciente WHERE (Dni LIKE @c OR CAST(IdPaciente AS VARCHAR) LIKE @c)";

                if (!string.IsNullOrEmpty(traslado) && traslado != "Todos")
                {
                    query += " AND Traslado = @t";
                }

                cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@c", "%" + criterio + "%");
                cmd.Parameters.AddWithValue("@t", traslado);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new EntPaciente
                    {
                        // Mapeamos IdPaciente al NumeroOrden de tu clase C#
                        NumeroOrden = Convert.ToInt32(dr["IdPaciente"]).ToString("D3"),
                        Dni = dr["Dni"].ToString(),
                        Nombres = dr["Nombres"].ToString(),
                        ApelPaterno = dr["ApelPaterno"].ToString(),
                        ApelMaterno = dr["ApelMaterno"].ToString(),
                        Celular = dr["Celular"].ToString(),
                        Edad = Convert.ToInt32(dr["Edad"]),
                        Traslado = dr["Traslado"].ToString(),
                        FechaNacimiento = dr["FechaNacimiento"] != DBNull.Value ? Convert.ToDateTime(dr["FechaNacimiento"]) : DateTime.Now
                    });
                }
            }
            catch (Exception e) { throw e; }
            finally { if (cmd != null) cmd.Connection.Close(); }
            return lista;
        }
        private string CalcularEdadDetallada(DateTime fechaNacimiento)
        {
            DateTime hoy = DateTime.Today;
            int años = hoy.Year - fechaNacimiento.Year;
            int meses = hoy.Month - fechaNacimiento.Month;

            if (hoy.Day < fechaNacimiento.Day) meses--;
            if (meses < 0)
            {
                años--;
                meses += 12;
            }
            return $"{años} años y {meses} meses";
        }

        bool HasColumn(SqlDataReader r, string columnName)
        {
            for (int i = 0; i < r.FieldCount; i++)
                if (r.GetName(i).Equals(columnName, StringComparison.OrdinalIgnoreCase)) return true;
            return false;
        }
        public List<EntPaciente> ListarPacientesEmergencia()
        {
            List<EntPaciente> lista = new List<EntPaciente>();
            string query = "SELECT IdPaciente, Dni, Nombres, ApelPaterno, ApelMaterno, Celular, Edad, Traslado, FechaNacimiento " +
                           "FROM Paciente WHERE Traslado = 'Emergencia'";

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                try
                {
                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new EntPaciente
                            {
                                NumeroOrden = Convert.ToInt32(dr["IdPaciente"]).ToString("D3"),
                                Dni = dr["Dni"].ToString(),
                                Nombres = dr["Nombres"].ToString(),
                                ApelPaterno = dr["ApelPaterno"].ToString(),
                                ApelMaterno = dr["ApelMaterno"].ToString(),
                                Celular = dr["Celular"].ToString(),
                                Edad = Convert.ToInt32(dr["Edad"]),
                                Traslado = dr["Traslado"].ToString(),
                                FechaNacimiento = dr["FechaNacimiento"] != DBNull.Value ? Convert.ToDateTime(dr["FechaNacimiento"]) : (DateTime?)null
                            });
                        }
                    }
                }
                catch (Exception ex) { throw ex; }
            }
            return lista;
        }
        public List<EntPaciente> BuscarPacienteEmergencia(string criterio)
        {
            List<EntPaciente> lista = new List<EntPaciente>();
            // Buscamos solo pacientes con traslado a 'Emergencia'
            string query = "SELECT * FROM Paciente WHERE Traslado = 'Emergencia' AND " +
                           "(Dni LIKE @c OR CAST(IdPaciente AS VARCHAR) LIKE @c)";

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cmd.Parameters.AddWithValue("@c", "%" + criterio + "%");
                try
                {
                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new EntPaciente
                            {
                                NumeroOrden = Convert.ToInt32(dr["IdPaciente"]).ToString("D3"),
                                Dni = dr["Dni"].ToString(),
                                Nombres = dr["Nombres"].ToString(),
                                ApelPaterno = dr["ApelPaterno"].ToString(),
                                ApelMaterno = dr["ApelMaterno"].ToString(),
                                Edad = Convert.ToInt32(dr["Edad"])
                            });
                        }
                    }
                }
                catch (Exception ex) { throw ex; }
            }
            return lista;
        }
    }
}
