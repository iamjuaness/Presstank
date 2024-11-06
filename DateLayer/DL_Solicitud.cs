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
        public List<SolicitudDTO> GetSolicitudes()
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
                    Empleado emp ON s.ID_Empleado = emp.ID_Empleado";

                    SqlCommand cmd = new SqlCommand(query, conn);
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

    }
}
