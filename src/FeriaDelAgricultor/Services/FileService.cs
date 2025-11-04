using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace FeriaDelAgricultor.Services
{
    /// <summary>
    /// Servicio reutilizable para leer y escribir archivos JSON.
    /// Cumple con SOLID: Single Responsibility (solo maneja archivos).
    /// </summary>
    public static class FileService
    {
        // Ruta base: bin/Debug/net9.0-windows/Data/
        private static readonly string BasePath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, "Data");

        // Constructor estático: crea la carpeta Data si no existe
        static FileService()
        {
            if (!Directory.Exists(BasePath))
                Directory.CreateDirectory(BasePath);
        }

        /// <summary>
        /// Carga una lista de objetos desde un archivo JSON.
        /// Si el archivo no existe, crea uno vacío.
        /// </summary>
        public static List<T> CargarJson<T>(string nombreArchivo)
        {
            string ruta = Path.Combine(BasePath, nombreArchivo);

            // Si no existe, crea archivo vacío
            if (!File.Exists(ruta))
            {
                File.WriteAllText(ruta, "[]");
                return new List<T>();
            }

            string json = File.ReadAllText(ruta);
            return JsonConvert.DeserializeObject<List<T>>(json) ?? new List<T>();
        }

        /// <summary>
        /// Guarda una lista de objetos en un archivo JSON.
        /// Formato legible (indentado).
        /// </summary>
        public static void GuardarJson<T>(string nombreArchivo, List<T> datos)
        {
            string ruta = Path.Combine(BasePath, nombreArchivo);
            string json = JsonConvert.SerializeObject(datos, Formatting.Indented);
            File.WriteAllText(ruta, json);
        }
    }
}