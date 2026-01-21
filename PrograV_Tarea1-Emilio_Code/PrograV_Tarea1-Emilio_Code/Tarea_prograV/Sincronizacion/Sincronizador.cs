using Tarea_prograV.Configuracion;
using Tarea_prograV.Dominio;
using Tarea_prograV.Infraestructura;

namespace Tarea_prograV.Sincronizacion
{
    public class Sincronizador
    {
        // Coordinara el proceso de sincronizacion

        private Settings _configuracion;
        private Replicador _replicador;

        /*Constructor*/
        public Sincronizador(Settings configuracion, Replicador replicador)
        {
            _configuracion = configuracion;
            _replicador = replicador;
        }

        public void ProcesarArchivo(Archivo archivo)
        {
            if (!_configuracion.sincronizacion)
                return;

            //Cambio necesario para bitacora KNG 

            try
            {
                _replicador.EnviarArchivo(archivo);

                // Registro de éxito
                string accion = archivo.eliminado ? "Eliminado" : "Sincronizado";
                Bitacora.RegistrarEvento($"{accion}: {archivo.nombre}");
            }
            catch (Exception ex)
            {
                // Registro de error técnico
                Bitacora.RegistrarError($"Error al procesar {archivo.nombre}: {ex.Message}");
                throw; // Re-lanzamos para que la UI
            }
        }

        public void Resincronizacion()
        {
            var archivos = Directory.GetFiles(_configuracion.ruta_carpeta_origen);

            foreach (var ruta in archivos)
            {
                var archivo = new Archivo
                {
                    nombre = Path.GetFileName(ruta),
                    ruta_completa = ruta,
                    eliminado = false,
                };

                _replicador.EnviarArchivo(archivo);

            }
        }

    }
}
