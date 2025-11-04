using FeriaDelAgricultor.Controllers;
using FeriaDelAgricultor.Models;
using System;
using System.Windows.Forms;

namespace FeriaDelAgricultor.Views
{
    public partial class frmRegistro : Form
    {
        private readonly UsuarioController _controlador = new UsuarioController();

        public frmRegistro()
        {
            InitializeComponent();
            this.txtContraseña.PasswordChar = '*';
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            var usuario = new Usuario
            {
                Nombre = this.txtNombre.Text.Trim(),
                Apellido = this.txtApellido.Text.Trim(),
                Correo = this.txtCorreo.Text.Trim(),
                Contraseña = this.txtContraseña.Text
            };

            if (_controlador.Registrar(usuario))
            {
                MessageBox.Show(
                    "¡Registro exitoso!\nPuedes iniciar sesión.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show(
                    "Este correo ya está registrado.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(this.txtNombre.Text) ||
                string.IsNullOrWhiteSpace(this.txtApellido.Text) ||
                string.IsNullOrWhiteSpace(this.txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(this.txtContraseña.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!this.txtCorreo.Text.Contains("@") || !this.txtCorreo.Text.Contains("."))
            {
                MessageBox.Show("Ingresa un correo válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            this.txtNombre.Clear();
            this.txtApellido.Clear();
            this.txtCorreo.Clear();
            this.txtContraseña.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}