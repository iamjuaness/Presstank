using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateLayer
{
    public class DL_Sucursal
    {
        public List<Sucursal> GetSucursales()
        {
            List<Sucursal> sucursales = new List<Sucursal>();

            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT ID_Sucursal, Nombre_Sucursal FROM Sucursal";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            sucursales.Add(new Sucursal
                            {
                                ID_Sucursal = Convert.ToInt32(reader["ID_Sucursal"]),
                                Nombre_Sucursal = reader["Nombre_Sucursal"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejar excepciones
                    Console.WriteLine($"Error al obtener sucursales: {ex.Message}");
                }
            }

            return sucursales;
        }
    }
}
