using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class UsuarioDAO
    {
        public string AutenticarUsuario(string idUsuario, string contraseña)
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                try
                {
                    SqlCommand comando = new SqlCommand("autenticar_usuario", conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@id_usuario", idUsuario);
                    comando.Parameters.AddWithValue("@contraseña", contraseña);

                    comando.ExecuteNonQuery(); 

                    return "Autenticación exitosa.";
                }
                catch (SqlException ex)
                {
                    
                    return ex.Message;
                }
                catch (Exception ex)
                {
                    return "Error inesperado: " + ex.Message;
                }
            }
        }
    }
}
