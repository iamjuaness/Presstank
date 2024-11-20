using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateLayer
{
    public class DL_Prestamo
    {

        public List<PrestamoDTO> GetPrestamos(int id)
        {
            List<PrestamoDTO> prestamos = new List<PrestamoDTO>();

            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"
                                   SELECT 
                                        ID_Prestamo, 
                                        Cantidad_Cuotas,
                                        Monto_Restante,
                                        Fecha_Vencimiento
                                   FROM Prestamo
                                   WHERE ID_Empleado = @ID_Empleado";


                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID_Empleado", id);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            prestamos.Add(new PrestamoDTO()
                            {
                                ID_Prestamo = Convert.ToInt32(reader["ID_Prestamo"]),
                                Fecha_Vencimiento = Convert.ToDateTime(reader["Fecha_Vencimiento"]),
                                Cantidad_Cuotas = Convert.ToInt32(reader["Cantidad_Cuotas"]),
                                Monto_Restante = Convert.ToDecimal(reader["Monto_Restante"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al obtener los prestamos: {ex.Message}");
                }
            }

            return prestamos;
        }

        public Boolean CreatePrestamos(Prestamo prestamo)
        {
            // Establecer la conexión a la base de datos
            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    // Consulta SQL para insertar una nueva sucursal
                    string query = @"
                                INSERT INTO Prestamo (Monto_Desembolsado, Fecha_Desembolso, ID_Empleado, ID_Solicitud, Cantidad_Cuotas, Monto_Restante, Fecha_Vencimiento)
                                VALUES (@Monto_Desembolsado, @Fecha_Desembolso, @ID_Empleado, @ID_Solicitud, @Cantidad_Cuotas, @Monto_Restante, @Fecha_Vencimiento)";

                    // Crear el comando SQL dentro de un bloque 'using'
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Agregar parámetros al comando
                        cmd.Parameters.AddWithValue("@Monto_Desembolsado", prestamo.Monto_Desembolsado);
                        cmd.Parameters.AddWithValue("@Fecha_Desembolso", prestamo.Fecha_Desembolso);
                        cmd.Parameters.AddWithValue("@ID_Empleado", prestamo.ID_Empleado);
                        cmd.Parameters.AddWithValue("@ID_Solicitud", prestamo.ID_Solicitud);
                        cmd.Parameters.AddWithValue("@Cantidad_Cuotas", prestamo.Cantidad_Cuotas);
                        cmd.Parameters.AddWithValue("@Monto_Restante", prestamo.Monto_Restante);
                        cmd.Parameters.AddWithValue("@Fecha_Vencimiento", prestamo.Fecha_Vencimiento);

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
                    Console.WriteLine($"Error al crear el prestamo: {ex.Message}");
                    return false;
                }
            }
        }

        public Prestamo GetPrestmoByID(int ID)
        {
            Prestamo prestamo = new Prestamo();

            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"
                              SELECT 
                                    Monto_Desembolsado,
                                    Fecha_Desembolso,
                                    ID_Solicitud,
                                    Cantidad_Cuotas,
                                    Monto_Restante,
                                    ID_Empleado
                               FROM Prestamo 
                               WHERE ID_Prestamo = @ID_Prestamo";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@ID_Prestamo", ID);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            prestamo = new Prestamo()
                            {
                                ID_Prestamo = ID,
                                ID_Empleado = Convert.ToInt32(reader["ID_Empleado"]),
                                Monto_Desembolsado = Convert.ToDecimal(reader["Monto_Desembolsado"]),
                                Fecha_Desembolso = Convert.ToDateTime(reader["Fecha_Desembolso"]),
                                ID_Solicitud = Convert.ToInt32(reader["ID_Solicitud"]),
                                Cantidad_Cuotas = Convert.ToInt32(reader["Cantidad_Cuotas"]),
                                Monto_Restante = Convert.ToDecimal(reader["Monto_Restante"])
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    prestamo = null;
                }

                return prestamo;
            }
        }

    }
}
