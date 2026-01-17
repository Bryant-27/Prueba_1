using Tarea_prograV.Configuracion;

using Tarea_prograV.Infraestructura;
using Tarea_prograV.Sincronizacion;

class Program
{
    static void Main()
    {
       Settings settings = new Settings();
       settings.ruta_carpeta = "C://Sync";

       Replicador replicador = new Replicador();
        Sincronizador sincronizador = new Sincronizador(settings, replicador);

        Carpeta_sincronizcada carpeta = new Carpeta_sincronizcada(settings.ruta_carpeta);
        carpeta.Iniciar_Monitoreo();

        var archivo = carpeta.Detectar_Cambio();
        sincronizador.ProcesarArchivo(archivo);

    }
}