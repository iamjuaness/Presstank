using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
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
                    string query = "SELECT ID_Sucursal, Nombre_Sucursal, Direccion, ID_Municipio FROM Sucursal";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            sucursales.Add(new Sucursal
                            {
                                ID_Sucursal = Convert.ToInt32(reader["ID_Sucursal"]),
                                Nombre_Sucursal = reader["Nombre_Sucursal"].ToString(),
                                Direccion = reader["Direccion"].ToString(),
                                ID_Municipio = Convert.ToInt32(reader["ID_Municipio"])
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

        public Boolean DeleteSucursal(string id)
        {
            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"
                        DELETE 
                        FROM Sucursal
                        WHERE ID_Sucursal = @ID_Sucursal";

                    // Usando 'using' para el SqlCommand
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID_Sucursal", id);
                        conn.Open();

                        // Execute the command (ExecuteNonQuery returns the number of affected rows)
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // If the insertion failed (no rows affected), return false
                        if (rowsAffected == 0)
                        {
                            return false;
                        }
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    // Mejor manejo de excepciones
                    Console.WriteLine($"Error al eliminar la sucursal: {ex.Message}");
                    return false;
                }
            }
        }

        public Boolean CreateSucursal(Sucursal sucursal)
        {
            // Establecer la conexión a la base de datos
            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    // Consulta SQL para insertar una nueva sucursal
                    string query = @"
                INSERT INTO Sucursal (Nombre_Sucursal, Direccion, ID_Municipio)
                VALUES (@Nombre_Sucursal, @Direccion, @ID_Municipio)";

                    // Crear el comando SQL dentro de un bloque 'using'
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Agregar parámetros al comando
                        cmd.Parameters.AddWithValue("@Nombre_Sucursal", sucursal.Nombre_Sucursal);
                        cmd.Parameters.AddWithValue("@Direccion", sucursal.Direccion);
                        cmd.Parameters.AddWithValue("@ID_Municipio", sucursal.ID_Municipio);

                        // Abrir la conexión
                        conn.Open();

                        // Ejecutar el comando (ExecuteNonQuery devuelve el número de filas afectadas)
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Si no se insertó ninguna fila, retornar falso
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    // Manejar las excepciones e informar al usuario
                    Console.WriteLine($"Error al crear la sucursal: {ex.Message}");
                    return false;
                }
            }
        }
    }
}
