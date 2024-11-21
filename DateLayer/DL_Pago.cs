using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateLayer
{
    public class DL_Pago
    {
        public int GetCountPago(int idPrestamo)
        {
            int numeroCuota;
            using (var connection = new SqlConnection(Conexion.cadena))
            {
                connection.Open();

                // Consulta para obtener el número de la última cuota registrada
                string query = @"
                            SELECT ISNULL(MAX(Numero_Cuota), 0) AS UltimaCuota
                            FROM Pago_Cuota
                            WHERE ID_Prestamo = @ID_Prestamo";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID_Prestamo", idPrestamo);
                    var ultimaCuota = (int)command.ExecuteScalar();

                    // Si no hay pagos, la siguiente cuota será la primera
                    numeroCuota = ultimaCuota + 1;
                }
            }
            return numeroCuota;
        }

        public Boolean CreatePago(Pago_Cuota pago_Cuota)
        {
            // Establecer la conexión a la base de datos
            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    // Consulta SQL para insertar una nueva sucursal
                    string query = @"
                                INSERT INTO Pago_Cuota (Numero_Cuota, Fecha_Pago, Valor_Pago, ID_Prestamo)
                                VALUES (@Numero_Cuota, @Fecha_Pago, @Valor_Pago, @ID_Prestamo)";

                    // Crear el comando SQL dentro de un bloque 'using'
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Agregar parámetros al comando
                        cmd.Parameters.AddWithValue("@Numero_Cuota", pago_Cuota.Numero_Cuota);
                        cmd.Parameters.AddWithValue("@Fecha_Pago", pago_Cuota.Fecha_Pago);
                        cmd.Parameters.AddWithValue("@Valor_Pago", pago_Cuota.Valor_Pago);
                        cmd.Parameters.AddWithValue("@ID_Prestamo", pago_Cuota.ID_Prestamo);
       

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
    }
}
