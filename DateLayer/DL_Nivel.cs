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
    public class DL_Nivel
    {
        public List<Nivel_Usuario> GetNiveles()
        {
            List<Nivel_Usuario> niveles = new List<Nivel_Usuario>();

            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT ID_Nivel, Nivel FROM Nivel_Usuario WHERE Nivel <> 'Administrador(admin)'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            niveles.Add(new Nivel_Usuario
                            {
                                ID_Nivel = Convert.ToInt32(reader["ID_Nivel"]),
                                Nivel = reader["Nivel"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al obtener niveles de usuario: {ex.Message}");
                }
            }

            return niveles;
        }

        public Nivel_Usuario GetNivelByID(int ID)
        {
            Nivel_Usuario nivel = new Nivel_Usuario();

            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT Nivel FROM Nivel_Usuario WHERE ID_Nivel = @ID_Nivel";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@ID_Nivel", ID);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            nivel = new Nivel_Usuario()
                            {
                                ID_Nivel = ID,
                                Nivel = reader["Nivel"].ToString()
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    nivel = null;
                }

                return nivel;
            }
        }
    }
}
