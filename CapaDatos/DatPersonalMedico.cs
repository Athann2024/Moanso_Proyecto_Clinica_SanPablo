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
    public class DatPersonalMedico
    {
        private static readonly DatPersonalMedico _instancia = new DatPersonalMedico();
        public static DatPersonalMedico Instancia => _instancia;

        // Cambia el Data Source por el nombre de tu servidor (ej: LAPTOP-R90\SQLEXPRESS)
        string cadena = "Data Source=FABRICIO\\SQLEXPRESS01;Initial Catalog=ClinicaSanPablo;Integrated Security=True";

        public List<EntPersonalMedico> ListarPersonal()
        {
            SqlCommand cmd = null;
            List<EntPersonalMedico> lista = new List<EntPersonalMedico>();
            try
            {
                SqlConnection cn = new SqlConnection(cadena);
                cmd = new SqlCommand("SELECT * FROM PersonalMedico", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new EntPersonalMedico
                    {
                        IdMedico = Convert.ToInt32(dr["IdMedico"]),
                        Nombre = dr["Nombre"].ToString(),
                        Licencia = dr["Licencia"].ToString(),
                        Especialidad = dr["Especialidad"].ToString(),
                        Turno = dr["Turno"].ToString(),
                        Activo = Convert.ToBoolean(dr["Activo"])
                    });
                }
            }
            catch
            {
                // loguear si corresponde
                throw;
            }

            return lista;
        }

        public bool InsertarMedico(EntPersonalMedico m)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = new SqlConnection(cadena);
                cmd = new SqlCommand("INSERT INTO PersonalMedico (Nombre, Licencia, Especialidad, Turno, Activo) VALUES (@nom, @lic, @esp, @tur, 1)", cn);
                cmd.Parameters.AddWithValue("@nom", m.Nombre);
                cmd.Parameters.AddWithValue("@lic", m.Licencia);
                cmd.Parameters.AddWithValue("@esp", m.Especialidad);
                cmd.Parameters.AddWithValue("@tur", m.Turno);
                cn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception e) { throw e; }
            finally { if (cmd != null) cmd.Connection.Close(); }
        }
        public bool ModificarMedico(EntPersonalMedico m)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = new SqlConnection(cadena);
                cmd = new SqlCommand("UPDATE PersonalMedico SET Nombre=@nom, Licencia=@lic, Especialidad=@esp, Turno=@tur, Activo=@act WHERE IdMedico=@id", cn);
                cmd.Parameters.AddWithValue("@nom", m.Nombre);
                cmd.Parameters.AddWithValue("@lic", m.Licencia);
                cmd.Parameters.AddWithValue("@esp", m.Especialidad);
                cmd.Parameters.AddWithValue("@tur", m.Turno);
                cmd.Parameters.AddWithValue("@act", m.Activo);
                cmd.Parameters.AddWithValue("@id", m.IdMedico);
                cn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception e) { throw e; }
            finally { if (cmd != null) cmd.Connection.Close(); }
        }

        public bool InhabilitarMedico(int id)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = new SqlConnection(cadena);
                // Inhabilitar es cambiar el estado Activo a 0 (falso)
                cmd = new SqlCommand("UPDATE PersonalMedico SET Activo = 0 WHERE IdMedico = @id", cn);
                cmd.Parameters.AddWithValue("@id", id);
                cn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception e) { throw e; }
            finally { if (cmd != null) cmd.Connection.Close(); }
        }
        public List<string> ListarNombresMedicos()
        {
            List<string> lista = new List<string>();
            string query = "SELECT Nombre FROM PersonalMedico WHERE Activo = 1"; // Solo médicos activos

            // CORRECCIÓN: Usamos la variable 'cadena' local para asegurar la conexión
            using (SqlConnection cn = new SqlConnection(cadena))
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                try
                {
                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(dr["Nombre"].ToString());
                        }
                    }
                }
                catch (Exception ex) { throw new Exception("Error al cargar médicos: " + ex.Message); }
            }
            return lista;
        }
    }
}
