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
            

            _replicador.EnviarArchivo(archivo);
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
