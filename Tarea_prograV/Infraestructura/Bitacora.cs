using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_prograV.Infraestructura
{

    public class Bitacora
    {
        private static readonly string NombreArchivo = "bitacora.txt";

        public static void RegistrarEvento(string mensaje)
        {
            try
            {
                string usuario = Environment.UserName;
                string fechaHora = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string linea = $"[{fechaHora}] | Usuario: {usuario} | Evento: {mensaje}";

                File.AppendAllLines(NombreArchivo, new[] { linea });
            }
            catch (Exception)
            {
                // si falla no se detiene 
            }
        }

        public static void RegistrarError(string errorTecnico)
        {
            string fechaHora = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string linea = $"[ERROR][{fechaHora}] | Usuario: {Environment.UserName} | Detalle: {errorTecnico}";

            try { File.AppendAllLines(NombreArchivo, new[] { linea }); } catch { }
        }


    }// fin del public
}// fin name space
