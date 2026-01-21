using System;
using Tarea_prograV.Dominio;

namespace Tarea_prograV.Infraestructura
{
    public class Replicador
    {
        // Aqui se replicaran los archivos entre equipos

        /*Atributos*/

        private string _ruta_destino;


        /*Constructor*/
        public Replicador(string ruta_destino)
        {
            _ruta_destino = ruta_destino;
        }

        private void Esperar_archivo(string ruta)
        {
            while (true)
            {
                try
                {
                    using (FileStream fs = File.Open(ruta, FileMode.Open, FileAccess.Read, FileShare.None))
                    {
                            break;
                    }
                }
                catch (IOException)
                {
                    Console.WriteLine($"El archivo {ruta} está en uso. Esperando...");
                    System.Threading.Thread.Sleep(100); // se espera 100 ms antes de volver a intentar
                }
               
            }

        }


        /*Metodos*/
        public void EnviarArchivo(Archivo archivo)
        {
            string destino = Path.Combine(_ruta_destino, archivo.nombre);

            // Si el archivo ya no existe se elimina del destino
            if (archivo.eliminado)
            {
                if (File.Exists(destino))
                    File.Delete(destino);
                return;
            }

            Esperar_archivo(archivo.ruta_completa);
            File.Copy(archivo.ruta_completa, destino, true);
        }

        //public void Procesar_archivo(Archivo archivo)
        //{
        //    string destino = Path.Combine(_ruta_destino, archivo.nombre);

        //    if (!File.Exists(archivo.ruta_completa))
        //    {
        //        if (File.Exists(destino))
        //            File.Delete(destino);

        //        return;
        //    }

        //    File.Copy(archivo.ruta_completa, destino, true);
        //}
    }
}
