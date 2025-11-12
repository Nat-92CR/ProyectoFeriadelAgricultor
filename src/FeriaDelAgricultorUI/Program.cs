using FeriaDelAgricultorController;
using FeriaDelAgricultorController.Abstractions;
using FeriaDelAgricultorModels;
using System;
using System.IO;
using System.Windows.Forms;

namespace FeriaDelAgricultorUI
{
    internal static class Program
    {
        // 📂 Ruta del archivo de usuarios (CSV)
        // Se recomienda dejar el archivo "Usuario.csv" junto al .exe en la carpeta bin/Debug/...
        private static readonly string CostumersFilePath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Usuario.csv");

        /// <summary>
        /// Punto de entrada principal de la aplicación.
        /// Aquí se inicializa la configuración y se abre la ventana de inicio de sesión.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Inicializa la configuración visual de Windows Forms.
            ApplicationConfiguration.Initialize();

            // Carga los servicios necesarios para el controlador principal.
            var userController = LoadControllerService();

            // Inicia la vista principal del login.
            Application.Run(new LoginView(userController));
        }

        /// <summary>
        /// Carga el servicio principal de usuarios y valida si los datos existen.
        /// Si el archivo CSV no puede cargarse, la aplicación se cierra mostrando un mensaje.
        /// </summary>
        /// <returns>Una instancia del controlador de inicio de sesión (LoginController).</returns>
        private static LoginController LoadControllerService()
        {
            try
            {
                // El FileHandler maneja la carga de datos desde el archivo CSV.
                var userHandler = new UserHandler(new FileHandler());

                // Intenta cargar los usuarios desde el archivo.
                var couldLoadUsers = userHandler.LoadUsers(CostumersFilePath);

                if (!couldLoadUsers)
                {
                    MessageBox.Show(
                        "⚠️ No se pudieron cargar los usuarios desde la fuente de datos.\nLa aplicación se cerrará.",
                        "Error de carga",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    Environment.Exit(0);
                }

                // Devuelve el controlador de login listo para usar.
                return new LoginController(userHandler);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ocurrió un error al intentar iniciar la aplicación:\n{ex.Message}",
                    "Error crítico",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                Environment.Exit(0);
                return null!; // nunca se ejecuta realmente, pero evita advertencias de compilación.
            }
        }
    }
}
