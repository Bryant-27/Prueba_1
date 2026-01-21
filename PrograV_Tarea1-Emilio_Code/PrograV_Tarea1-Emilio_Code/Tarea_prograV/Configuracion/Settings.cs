

namespace Tarea_prograV.Configuracion
{
    public class Settings
    {
        // Gestiona la configuracion del sistema, guarda la ruta y la sincronizacion(pausado o no)

        /* Atributos */

        public string ruta_carpeta_origen { get; set; }

        public string ruta_carpeta_destino { get; set; }
        public bool sincronizacion { get; set; }

        /*Constructor*/
        public Settings()
        {
            sincronizacion = true; // true significa que la sincronizacion esta activa
        }

    }
}
