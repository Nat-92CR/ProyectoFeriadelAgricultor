using FeriaDelAgricultorModels;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FeriaDelAgricultorUI
{
    public partial class MainMenuView : Form
    {
        // Usuario que inició sesión
        private readonly Usuario usuario;

        /// <summary>
        /// Este constructor recibe el usuario luego del login.
        /// </summary>
        /// <param name="usuario">Usuario autenticado.</param>
        public MainMenuView(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            ConfigurarMensajeBienvenida();
        }

        /// <summary>
        /// Configura el mensaje de bienvenida según el tipo de usuario.
        /// </summary>
        private void ConfigurarMensajeBienvenida()
        {
            if (usuario == null)
            {
                lblBienvenida.Text = "Bienvenido al sistema Feria del Agricultor.";
                return;
            }

            // Nombre 
            string nombre = $"{usuario.Name} {usuario.LastName}".Trim();

            // Texto según tipo de usuario
            if (usuario.TipoUsuario == TipoUsuario.Cliente)
            {
                lblBienvenida.Text =
                    $"👋 ¡Bienvenid@ {nombre}! Has iniciado sesión como CLIENTE.";
                // Opcional: color de fondo para clientes
                this.BackColor = Color.LightSkyBlue;
            }
            else if (usuario.TipoUsuario == TipoUsuario.Productor)
            {
                lblBienvenida.Text =
                    $"🌾 ¡Hola {nombre}! Has iniciado sesión como PRODUCTOR.";
                // Opcional: color de fondo para productores
                this.BackColor = Color.Moccasin;
            }
            else
            {
                lblBienvenida.Text = $"Bienvenid@ {nombre}.";
            }
        }
    }
}
