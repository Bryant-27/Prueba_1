

namespace Tarea_prograV.Configuracion
{
    public class Settings
    {
        // Gestiona la configuracion del sistema, guarda la ruta y la sincronizacion(pausado o no)

        /* Atributos */

        public string ruta_carpeta { get; set; }
        public bool sincronizacion { get; set; }

        /*Metodos*/

        public void Config()
        {
            sincronizacion = true;
        }

        public void Pausar()
        {
            sincronizacion = false;
        }

        public void Reanudar()
        {
            sincronizacion = true;
        }

    }
}
