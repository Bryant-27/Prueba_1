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
            if (_configuracion.sincronizacion)
            {
                Console.WriteLine("Sincronizacion pausada.");
                return;
            }

            _replicador.EnviarArchivo(archivo);
        }

    }
}
