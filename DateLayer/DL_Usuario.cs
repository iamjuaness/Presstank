using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

using EntityLayer;

namespace DateLayer
{
    public class DL_Usuario
    {

        public List<Usuario> getUsuarios()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();

            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "select ID_Usuario, Nombre_Usuario, Contrasenia, ID_Nivel from usuario";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.CommandType = CommandType.Text;
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            listaUsuarios.Add(new Usuario()
                            {
                                ID_Usuario = Convert.ToInt32(reader["ID_Usuario"]),
                                Nombre_Usuario = reader["Nombre_Usuario"].ToString(),
                                Contrasenia = reader["Contrasenia"].ToString(),
                                ID_Nivel = Convert.ToInt32(reader["ID_Nivel"])
                            });
                        }
                    }

                }
                catch (Exception ex) 
                {

                    listaUsuarios = new List<Usuario>();
                    
                }

                return listaUsuarios;
            }
        }

        public Usuario GetUsuario(int id)
        {
            Usuario usuario = null;

            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"
                        SELECT 
                            Nombre_Usuario
                        FROM Usuario
                        WHERE ID_Usuario = @ID_Usuario";

                    // Usando 'using' para el SqlCommand
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID_Usuario", id);
                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                usuario = new Usuario()
                                {
                                    ID_Usuario = id,
                                    Nombre_Usuario = reader["Nombre_Usuario"].ToString(),
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

            return usuario;
        }


    }
}
