using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmLogin : Form
    {
        private UsuarioBO usuarioBO = new UsuarioBO();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            string idUsuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text;

            if (string.IsNullOrEmpty(idUsuario))
            {
                errorProvider1.SetError(txtUsuario, "Debe ingresar el RUT del usuario.");
                return;
            }

            if (string.IsNullOrEmpty(contraseña))
            {
                errorProvider1.SetError(txtContraseña, "Debe ingresar la contraseña.");
                return;
            }

            string resultado = usuarioBO.Autenticar(idUsuario, contraseña);

            if (resultado == "Autenticación exitosa.")
            {
                MessageBox.Show(resultado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Aquí se puede cerrar el formulario o mostrar el sistema principal
                this.Close();
            }
            else
            {
                MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Validar formato de RUT
            Regex rutRegex = new Regex(@"^\d{7,8}-[\dkK]$");
            if (!rutRegex.IsMatch(idUsuario))
            {
                errorProvider1.SetError(txtUsuario, "Formato de RUT inválido. Ej: 12345678-9");
                return;
            }
            // Validar formato de contraseña
            Regex contraseñaFuerte = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^a-zA-Z0-9]).{8,}$");
            if (!contraseñaFuerte.IsMatch(contraseña))
            {
                errorProvider1.SetError(txtContraseña, "La contraseña debe tener al menos 8 caracteres, incluyendo mayúscula, minúscula, número y símbolo.");
                return;
            }

        }
    }
}
