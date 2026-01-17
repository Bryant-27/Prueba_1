using System;
using Tarea_prograV.Dominio;

namespace Tarea_prograV.Sincronizacion
{
    public class Carpeta_sincronizcada 
    {
        // Representa una carpeta que se va a sincronizar
        // Detecta cambios en la carpeta y notifica al sincronizador

        public string Ruta { get; private set; }

        public Carpeta_sincronizcada(string ruta)
        {
            Ruta = ruta;
        }

        public void Iniciar_Monitoreo()
        {
            // Aqui iria el codigo para iniciar el monitoreo de la carpeta
            Console.WriteLine($"Monitoreo iniciado en la carpeta: {Ruta}");
        }

        public Archivo Detectar_Cambio()
        {
            // Aqui iria el codigo para detectar cambios en la carpeta
            // Por simplicidad, retornamos un archivo de ejemplo
            return new Archivo
            {
                nombre = "archivo_ejemplo.txt",
                ruta_completa = System.IO.Path.Combine(Ruta, "archivo_ejemplo.txt"),
                tamano = 2048
            };
        }

    }
}
