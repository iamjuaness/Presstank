using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateLayer
{
    public class DL_Municipio
    {
        public List<Municipio> GetMunicipios()
        {
            List<Municipio> municipios = new List<Municipio>();

            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT ID_Municipio, Nombre_Municipio FROM Municipio";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            municipios.Add(new Municipio
                            {
                                ID_Municipio = Convert.ToInt32(reader["ID_Municipio"]),
                                Nombre_Municipio = reader["Nombre_Municipio"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejar excepciones
                    Console.WriteLine($"Error al obtener municipios: {ex.Message}");
                }
            }

            return municipios;
        }

        public Municipio GetMunicipio(int id)
        {
            Municipio municipio = null; // Inicialización aquí en lugar de una nueva instancia

            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"
                        SELECT Nombre_Municipio 
                        FROM Municipio
                        WHERE ID_Municipio = @ID_Municipio";

                    // Usando 'using' para el SqlCommand
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID_Municipio", id);
                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                municipio = new Municipio()
                                {
                                    ID_Municipio = id,
                                    Nombre_Municipio = reader["Nombre_Municipio"].ToString()
                                };
                            }
                            else
                            {
                                // En caso de no encontrar resultados
                                Console.WriteLine("No se encontró el municipio con el ID proporcionado.");
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

            return municipio;
        }
    }
}
