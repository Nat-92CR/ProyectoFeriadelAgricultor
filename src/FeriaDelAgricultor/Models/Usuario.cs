using System.Collections.Generic;

namespace FeriaDelAgricultor.Models
{
    /// <summary>
    /// Representa un usuario del sistema (comprador).
    /// Cumple con POO: encapsulamiento, inicialización segura.
    /// </summary>
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;
        public string Contraseña { get; set; } = string.Empty;
        public List<Direccion> Direcciones { get; set; } = new();

        // Constructor vacío (necesario para deserialización JSON)
        public Usuario() { }

        // Constructor con parámetros
        public Usuario(int id, string nombre, string apellido, string correo, string contraseña)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            Contraseña = contraseña;
        }
    }

    /// <summary>
    /// Representa una dirección de envío del usuario.
    /// Relación 1 a N con Usuario.
    /// </summary>
    public class Direccion
    {
        public int Id { get; set; }
        public string Provincia { get; set; } = string.Empty;
        public string Canton { get; set; } = string.Empty;
        public string Distrito { get; set; } = string.Empty;
        public string Detalles { get; set; } = string.Empty;
        public bool EsPrincipal { get; set; }

        public override string ToString()
        {
            return $"{Provincia}, {Canton}, {Distrito} - {Detalles}";
        }
    }
}
