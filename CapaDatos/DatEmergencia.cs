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
    public class DatEmergencia
    {
        private static readonly DatEmergencia _instancia = new DatEmergencia();
        public static DatEmergencia Instancia => _instancia;

        public bool InsertarEmergencia(EntEmergencia e)
        {
            SqlCommand cmd = null;
            bool inserto = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                // Usaremos una consulta directa para asegurar que coincida con tus columnas de SQL
                string query = "INSERT INTO Emergencia (DniPaciente, MotivoUrgencia, NivelTriaje, Medicamento, PersonalMedico, Estado, FechaIngreso) " +
                               "VALUES (@Dni, @Motivo, @Triaje, @Med, @Medico, @Estado, @Fecha)";

                cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@Dni", e.DniPaciente);
                cmd.Parameters.AddWithValue("@Motivo", e.MotivoUrgencia);
                cmd.Parameters.AddWithValue("@Triaje", e.NivelTriaje);
                cmd.Parameters.AddWithValue("@Med", e.Medicamento);

                // AGREGAR ESTAS LÍNEAS QUE FALTABAN:
                cmd.Parameters.AddWithValue("@Medico", e.PersonalMedico);
                cmd.Parameters.AddWithValue("@Estado", e.Estado);
                cmd.Parameters.AddWithValue("@Fecha", e.FechaIngreso);

                cn.Open();
                if (cmd.ExecuteNonQuery() > 0) inserto = true;
            }
            catch (Exception ex) { throw ex; }
            finally { if (cmd != null) cmd.Connection.Close(); }
            return inserto;
        }

        public List<EntEmergencia> ListarEmergencias()
        {
            List<EntEmergencia> lista = new List<EntEmergencia>();

            // AQUÍ SE PONE: Asegúrate de que los nombres coincidan con tu tabla SQL
            string query = "SELECT DniPaciente, MotivoUrgencia, FechaIngreso, NivelTriaje, Medicamento, Estado, PersonalMedico FROM Emergencia";

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
                            lista.Add(new EntEmergencia
                            {
                                DniPaciente = dr["DniPaciente"].ToString(),
                                MotivoUrgencia = dr["MotivoUrgencia"].ToString(),
                                FechaIngreso = Convert.ToDateTime(dr["FechaIngreso"]),
                                NivelTriaje = Convert.ToInt32(dr["NivelTriaje"]),
                                Medicamento = dr["Medicamento"].ToString(),

                                // ESTAS LÍNEAS SON LAS QUE FALTAN:
                                Estado = dr["Estado"].ToString(),
                                PersonalMedico = dr["PersonalMedico"].ToString()
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
