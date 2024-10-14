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
    public class DL_Empleado
    {

        public List<Empleado> getEmpleados()
        {
            List<Empleado> listaEmpleado = new List<Empleado>();

            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "select ID_Empleado, Nombre, ID_Sucursal, ID_Usuario, ID_Cargo from empleado";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.CommandType = CommandType.Text;
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaEmpleado.Add(new Empleado()
                            {
                                ID_Empleado = Convert.ToInt32(reader["ID_Empleado"]),
                                Nombre = reader["Nombre"].ToString(),
                                ID_Sucursal = Convert.ToInt32(reader["ID_Sucursal"]),
                                ID_Usuario = Convert.ToInt32(reader["ID_Usuario"]),
                                ID_Cargo = Convert.ToInt32(reader["ID_Cargo"])
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    listaEmpleado = new List<Empleado>();
                }

                return listaEmpleado;
            }
        }

        public Empleado GetEmpleadoByID(int idUser)
        {
            Empleado empleado = new Empleado();

            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "select ID_Empleado, Nombre, ID_Sucursal, ID_Usuario, ID_Cargo from empleado where ID_Usuario = @ID_Usuario";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@ID_Usuario", idUser);


                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                       if (reader.Read())
                        {
                            empleado = new Empleado()
                            {
                                ID_Empleado = Convert.ToInt32(reader["ID_Empleado"]),
                                Nombre = reader["Nombre"].ToString(),
                                ID_Sucursal = Convert.ToInt32(reader["ID_Sucursal"]),
                                ID_Usuario = Convert.ToInt32(reader["ID_Usuario"]),
                                ID_Cargo = Convert.ToInt32(reader["ID_Cargo"])
                            };
                        }
                    }

                }
                catch (Exception ex)
                {
                    empleado = null;
                }

                return empleado;
            }
        }
    }
}
