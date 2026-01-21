using System;
using Tarea_prograV.Dominio;

namespace Tarea_prograV.Sincronizacion
{
    public class Carpeta_sincronizcada 
    {
        // Representa una carpeta que se va a sincronizar
        // Detecta cambios en la carpeta y notifica al sincronizador

        private FileSystemWatcher _watcher;

        public string Ruta { get; private set; }

        public Carpeta_sincronizcada(string ruta)
        {
            Ruta = ruta;
        }

        private Archivo Eliminar_archivo(string ruta_archivo)
        {
            return new Archivo
            {
                nombre = Path.GetFileName(ruta_archivo),
                ruta_completa = ruta_archivo
            };
        }

        public void Iniciar_Monitoreo(Action<Archivo> cambio_archivo)
        {
            _watcher = new FileSystemWatcher(Ruta);
            _watcher.IncludeSubdirectories = false;
            _watcher.EnableRaisingEvents = true;

            _watcher.Created += (s, e) =>
            {
                cambio_archivo(Obtener_Archivo(e.FullPath));
            };

            _watcher.Changed += (s, e) =>
            {
                cambio_archivo(Obtener_Archivo(e.FullPath));
            };

            _watcher.Renamed += (s, e) =>
            {
                cambio_archivo(Obtener_Archivo(e.FullPath));
            };

            _watcher.Deleted += (s, e) =>
            {
                cambio_archivo(Obtener_Archivo(e.FullPath));
            };
        }

        public Archivo Obtener_Archivo(string ruta_archivo)
        {
            // Aqui iria el codigo para detectar cambios en la carpeta
            
            if (!File.Exists(ruta_archivo))
            {
                return new Archivo
                {
                    nombre = Path.GetFileName(ruta_archivo),
                    ruta_completa = ruta_archivo,
                    eliminado = true
                };
            }

            FileInfo cambios = new FileInfo(ruta_archivo);

            return new Archivo
            {
                nombre = cambios.Name,
                ruta_completa = cambios.FullName,
                tamano = cambios.Length,
                eliminado = false
            };
        }

    }
}
