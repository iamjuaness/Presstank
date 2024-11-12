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

        public Sucursal GetSucursal(int id)
        {
            Sucursal sucursal = null; // Inicialización aquí en lugar de una nueva instancia

            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"
                        SELECT Nombre_Sucursal 
                        FROM Sucursal
                        WHERE ID_Sucursal = @ID_Sucursal";

                    // Usando 'using' para el SqlCommand
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID_Sucursal", id);
                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                sucursal = new Sucursal()
                                {
                                    ID_Sucursal = id,
                                    Nombre_Sucursal = reader["Nombre_Sucursal"].ToString()
                                };
                            }
                            else
                            {
                                // En caso de no encontrar resultados
                                Console.WriteLine("No se encontró la sucursal con el ID proporcionado.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Mejor manejo de excepciones
                    Console.WriteLine($"Error al obtener la sucursal: {ex.Message}");
                }
            }

            return sucursal;
        }

    }
}
