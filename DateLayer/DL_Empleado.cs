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
        int currentIdentity;

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

        public Empleado GetEmpleadoByIDUsuario(int idUser)
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
                                ID_Usuario = idUser,
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

        public Empleado GetEmpleadoByID(int idEmpleado)
        {
            Empleado empleado = new Empleado();

            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "select Nombre, ID_Sucursal, ID_Usuario, ID_Cargo from empleado where ID_Empleado = @ID_Empleado";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@ID_Empleado", idEmpleado);


                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            empleado = new Empleado()
                            {
                                ID_Empleado = idEmpleado,
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

        /// <summary>
        /// Registra un empleado y su usuario asociado en la base de datos.
        /// </summary>
        /// <param name="empleado">Objeto Empleado con la información a registrar.</param>
        /// <param name="usuario">Objeto Usuario con la información a registrar.</param>
        /// <returns>Retorna true si el registro fue exitoso, false si no.</returns>
        public bool RegisterEmployeeAndUser(Empleado empleado, Usuario usuario)
        {
            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                conn.Open();
                SqlTransaction transaction = null;
                try
                {
                    transaction = conn.BeginTransaction();

                    // Obtener el valor actual de la identidad antes de la inserción
                    using (SqlCommand cmdGetIdentity = new SqlCommand("SELECT IDENT_CURRENT('Usuario')", conn, transaction))
                    {
                        currentIdentity = Convert.ToInt32(cmdGetIdentity.ExecuteScalar());
                    }

                    // Insertar el usuario
                    string insertUserQuery = @"
            INSERT INTO Usuario (Nombre_Usuario, Contrasenia, ID_Nivel)
            VALUES (@Nombre_Usuario, @Contrasenia, @ID_Nivel);
            SELECT SCOPE_IDENTITY();";

                    int idUsuario;
                    using (SqlCommand cmdUser = new SqlCommand(insertUserQuery, conn, transaction))
                    {
                        cmdUser.Parameters.AddWithValue("@Nombre_Usuario", usuario.Nombre_Usuario);
                        cmdUser.Parameters.AddWithValue("@Contrasenia", usuario.Contrasenia);
                        cmdUser.Parameters.AddWithValue("@ID_Nivel", usuario.ID_Nivel);
                        idUsuario = Convert.ToInt32(cmdUser.ExecuteScalar());
                    }

                    // Insertar el empleado con el ID_Usuario obtenido
                    string insertEmployeeQuery = @"
            INSERT INTO Empleado (ID_Empleado, Nombre, ID_Sucursal, ID_Usuario, ID_Cargo)
            VALUES (@ID_Empleado, @Nombre, @ID_Sucursal, @ID_Usuario, @ID_Cargo);";

                    using (SqlCommand cmdEmployee = new SqlCommand(insertEmployeeQuery, conn, transaction))
                    {
                        cmdEmployee.Parameters.AddWithValue("@ID_Empleado", empleado.ID_Empleado);
                        cmdEmployee.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                        cmdEmployee.Parameters.AddWithValue("@ID_Sucursal", empleado.ID_Sucursal);
                        cmdEmployee.Parameters.AddWithValue("@ID_Usuario", idUsuario);
                        cmdEmployee.Parameters.AddWithValue("@ID_Cargo", empleado.ID_Cargo);
                        cmdEmployee.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    if (transaction != null)
                    {
                        transaction.Rollback();

                        // Restaurar el valor de la identidad al valor original
                        string reseedQuery = "DBCC CHECKIDENT ('Usuario', RESEED, @Identity);";
                        using (SqlCommand cmdReseed = new SqlCommand(reseedQuery, conn))
                        {
                            cmdReseed.Parameters.AddWithValue("@Identity", currentIdentity);
                            cmdReseed.ExecuteNonQuery();
                        }
                    }

                    Console.WriteLine($"Error al registrar el empleado y usuario: {ex.Message}");
                    return false;
                }
                finally
                {
                    if (transaction != null)
                    {
                        transaction.Dispose();
                    }
                }
            }
        }


    }
}
