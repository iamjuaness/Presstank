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


    }
}
