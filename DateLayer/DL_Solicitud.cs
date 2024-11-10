using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateLayer
{
    public class DL_Solicitud
    {
        public List<SolicitudDTO> GetSolicitudes(string estado)
        {
            List<SolicitudDTO> solicitudesDTO = new List<SolicitudDTO>();

            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"
                SELECT 
                    s.ID_Solicitud,
                    s.Fecha_Solicitud,
                    s.Monto_Solicitado,
                    p.CANTIDAD_MESES AS Periodo,
                    e.Estado AS Estado_Solicitud,
                    emp.Nombre AS Empleado
                FROM 
                    Solicitud s
                JOIN 
                    Periodo p ON s.ID_Periodo = p.ID_Periodo
                JOIN 
                    Estado_Solicitud e ON s.ID_Estado = e.ID_Estado
                JOIN 
                    Empleado emp ON s.ID_Empleado = emp.ID_Empleado
                WHERE e.ID_Estado = @Estado_Solicitud";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Estado_Solicitud", estado);

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            solicitudesDTO.Add(new SolicitudDTO
                            {
                                ID_Solicitud = Convert.ToInt32(reader["ID_Solicitud"]),
                                Fecha_Solicitud = Convert.ToDateTime(reader["Fecha_Solicitud"]),
                                Monto_Solicitado = Convert.ToDecimal(reader["Monto_Solicitado"]),
                                Periodo = Convert.ToInt32(reader["Periodo"]),
                                Estado_Solicitud = reader["Estado_Solicitud"].ToString(),
                                Empleado = reader["Empleado"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al obtener solicitudes: {ex.Message}");
                }
            }

            return solicitudesDTO;
        }

        public List<MisSolicitudesDTO> GetSolicitudesByID(int ID)
        {
            List<MisSolicitudesDTO> solicitudesDTO = new List<MisSolicitudesDTO>();

            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"
                    SELECT 
                        s.ID_Solicitud,
                        s.Fecha_Solicitud,
                        s.Monto_Solicitado,
                        p.CANTIDAD_MESES AS Periodo,
                        e.Estado AS Estado_Solicitud
                    FROM 
                        Solicitud s
                    JOIN 
                        Periodo p ON s.ID_Periodo = p.ID_Periodo
                    JOIN 
                        Estado_Solicitud e ON s.ID_Estado = e.ID_Estado
                    WHERE ID_Empleado = @ID_Usuario";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID_Usuario", ID);

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            solicitudesDTO.Add(new MisSolicitudesDTO
                            {
                                ID_Solicitud = Convert.ToInt32(reader["ID_Solicitud"]),
                                Fecha_Solicitud = Convert.ToDateTime(reader["Fecha_Solicitud"]),
                                Monto_Solicitado = Convert.ToDecimal(reader["Monto_Solicitado"]),
                                Periodo = Convert.ToInt32(reader["Periodo"]),
                                Estado_Solicitud = reader["Estado_Solicitud"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al obtener solicitudes: {ex.Message}");
                }
            }
            return solicitudesDTO;
        }

        public Boolean crearSolicitud(Solicitud solicitud)
        {
            // Using a 'using' block to ensure the connection is closed automatically
            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    // Define the SQL query to insert a new solicitud record
                    string query = @"
                    INSERT INTO 
                        SOLICITUD (
                            Fecha_Solicitud, 
                            Monto_Solicitado, 
                            ID_Periodo, 
                            ID_Estado, 
                            ID_Empleado
                        )
                    VALUES (
                        @Fecha_Solicitud,
                        @Monto_Solicitado,
                        @ID_Periodo,
                        @ID_Estado, 
                        @ID_Empleado
                    )";

                    // Prepare the SQL command and set the connection and query
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Add parameters to prevent SQL injection and handle data dynamically
                    cmd.Parameters.AddWithValue("@Fecha_Solicitud", solicitud.Fecha_Solicitud);
                    cmd.Parameters.AddWithValue("@Monto_Solicitado", solicitud.Monto_Solicitado);
                    cmd.Parameters.AddWithValue("@ID_Periodo", solicitud.ID_Periodo);
                    cmd.Parameters.AddWithValue("@ID_Estado", solicitud.ID_Estado);
                    cmd.Parameters.AddWithValue("@ID_Empleado", solicitud.ID_Empleado);

                    // Open the database connection
                    conn.Open();

                    // Execute the command (ExecuteNonQuery returns the number of affected rows)
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // If the insertion failed (no rows affected), return false
                    if (rowsAffected == 0)
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    // Handle the exception if needed, for now, just returning false
                    // Optionally, log or output the exception
                    return false;
                }
            }

            // If everything went well, return true
            return true;
        }

        public Boolean cambiarEstadoSolicitud(string idSolicitud, string estado)
        {
            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"
                        UPDATE solicitud
                        SET ID_Estado = @Estado_Solicitud
                        WHERE ID_Solicitud = @ID_Solicitud
                    ";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@Estado_Solicitud", estado);
                    cmd.Parameters.AddWithValue("@ID_Solicitud", idSolicitud);

                    // Open the database connection
                    conn.Open();

                    // Execute the command (ExecuteNonQuery returns the number of affected rows)
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // If the insertion failed (no rows affected), return false
                    if (rowsAffected == 0)
                    {
                        return false;
                    }


                } catch (Exception ex)
                {
                    return false;
                }

                return true;
            }
        }
    }
}
