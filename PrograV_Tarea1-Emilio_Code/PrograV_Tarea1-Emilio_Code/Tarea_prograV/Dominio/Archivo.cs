
namespace Tarea_prograV.Dominio
{
    public class Archivo
    {
        // Representa el archivo del sistema, este no hace nada de la sincronizacion

        /*Atributos*/

        public string nombre { get; set; }
        public string ruta_completa { get; set; }
        public long tamano { get; set; }
        public bool eliminado { get; set; }


    }
}
