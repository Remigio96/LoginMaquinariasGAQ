using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class UsuarioBO
    {
        private UsuarioDAO usuarioDAO = new UsuarioDAO();

        public string Autenticar(string idUsuario, string contraseña)
        {
            // Validación simple de campos
            if (string.IsNullOrWhiteSpace(idUsuario))
                return "Debe ingresar el RUT del usuario.";

            if (string.IsNullOrWhiteSpace(contraseña))
                return "Debe ingresar la contraseña.";

            // Llama al DAO para ejecutar el procedimiento almacenado
            string resultado = usuarioDAO.AutenticarUsuario(idUsuario, contraseña);
            return resultado;
        }
    }
}
