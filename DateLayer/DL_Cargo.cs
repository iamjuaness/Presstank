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

        public Cargo GetCargo(int id)
        {
            Cargo cargo = null;

            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"
                            SELECT Nombre_Cargo 
                            FROM Cargo
                            WHERE ID_Cargo = @ID_Cargo";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID_Cargo", id);
                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                cargo = new Cargo()
                                {
                                    ID_Cargo = id,
                                    Nombre_Cargo = reader["Nombre_Cargo"].ToString()
                                };
                            }
                            else
                            {
                                
                                Console.WriteLine("No se encontró el cargo con el ID proporcionado.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al obtener el cargo: {ex.Message}");
                }
            }

            return cargo;
        }

    }
}
