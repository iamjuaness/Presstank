using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateLayer
{
    public class DL_Cargo
    {
        public List<Cargo> GetCargos()
        {
            List<Cargo> cargos = new List<Cargo>();

            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT ID_Cargo, Nombre_Cargo FROM Cargo";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cargos.Add(new Cargo
                            {
                                ID_Cargo = Convert.ToInt32(reader["ID_Cargo"]),
                                Nombre_Cargo = reader["Nombre_Cargo"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al obtener cargos: {ex.Message}");
                }
            }

            return cargos;
        }
    }
}
