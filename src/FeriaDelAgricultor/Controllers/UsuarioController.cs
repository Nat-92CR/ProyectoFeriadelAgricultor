using FeriaDelAgricultor.Models;
using FeriaDelAgricultor.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FeriaDelAgricultor.Controllers
{
    /// <summary>
    /// Controlador para gestión de usuarios (MVC).
    /// Cumple con SOLID: Single Responsibility.
    /// </summary>
    public class UsuarioController
    {
        private List<Usuario> _usuarios;

        public UsuarioController()
        {
            _usuarios = FileService.CargarJson<Usuario>("usuarios.json");
        }

        /// <summary>
        /// Registra un nuevo usuario.
        /// </summary>
        public bool Registrar(Usuario usuario)
        {
            // Validar correo único
            if (_usuarios.Any(u => u.Correo.Equals(usuario.Correo, StringComparison.OrdinalIgnoreCase)))
                return false;

            // ID autoincremental
            usuario.Id = _usuarios.Count > 0 ? _usuarios.Max(u => u.Id) + 1 : 1;

            _usuarios.Add(usuario);
            FileService.GuardarJson("usuarios.json", _usuarios);
            return true;
        }

        /// <summary>
        /// Inicia sesión (para mañana).
        /// </summary>
        public Usuario? IniciarSesion(string correo, string contraseña)
        {
            return _usuarios.FirstOrDefault(u =>
                u.Correo.Equals(correo, StringComparison.OrdinalIgnoreCase) &&
                u.Contraseña == contraseña);
        }
    }
}