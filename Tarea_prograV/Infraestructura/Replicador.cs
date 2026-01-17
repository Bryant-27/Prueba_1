using System;
using Tarea_prograV.Dominio;

namespace Tarea_prograV.Infraestructura
{
    public class Replicador
    {
        public void EnviarArchivo(Archivo archivo)
        {
            Console.WriteLine($"Recopilando archivo: {archivo}");
        }
    }
}
