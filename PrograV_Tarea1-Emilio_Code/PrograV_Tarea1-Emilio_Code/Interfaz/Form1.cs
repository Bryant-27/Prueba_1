using Tarea_prograV.Configuracion;
using Tarea_prograV.Dominio;
using Tarea_prograV.Infraestructura;
using Tarea_prograV.Sincronizacion;
using System;

namespace Interfaz
{
    public partial class Form1 : Form
    {
        Settings settings;
        Carpeta_sincronizcada CS;
        Replicador replicador;
        Sincronizador sincronizador;

        public Form1()
        {
            InitializeComponent();
            ActualizarEstadoUI(false);
        }

        private void ActualizarEstadoUI(bool sincronizacionActiva)
        {
            btnIniciar.Enabled = !sincronizacionActiva;
            btnPausar.Enabled = sincronizacionActiva;
            btnReanudar.Enabled = !sincronizacionActiva;
            btnOrigen.Enabled = !sincronizacionActiva;
            btnDestino.Enabled = !sincronizacionActiva;
        }


        private void btnOrigen_Click(object sender, EventArgs e)
        {
            using FolderBrowserDialog dialog = new();

            if (dialog.ShowDialog() == DialogResult.OK)
                txtOrigen.Text = dialog.SelectedPath;
        }

        private void btnDestino_Click(object sender, EventArgs e)
        {
            using FolderBrowserDialog dialog = new();

            if (dialog.ShowDialog() == DialogResult.OK)
                txtDestino.Text = dialog.SelectedPath;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                settings = new Settings
                {
                    ruta_carpeta_origen = txtOrigen.Text,
                    ruta_carpeta_destino = txtDestino.Text,
                    sincronizacion = true
                };

                Directory.CreateDirectory(settings.ruta_carpeta_origen);
                Directory.CreateDirectory(settings.ruta_carpeta_destino);

                CS = new Carpeta_sincronizcada(settings.ruta_carpeta_origen);
                replicador = new Replicador(settings.ruta_carpeta_destino);
                sincronizador = new Sincronizador(settings, replicador);

                // Sincronización inicial
                foreach (string rutaArchivo in Directory.GetFiles(settings.ruta_carpeta_origen))
                {
                    Archivo archivo = CS.Obtener_Archivo(rutaArchivo);
                    sincronizador.ProcesarArchivo(archivo);
                }

                // Monitoreo
                CS.Iniciar_Monitoreo(archivo =>
                {
                    Invoke(() =>
                    {
                        lstLog.Items.Add($"Cambio detectado: {archivo.nombre}");
                    });

                    sincronizador.ProcesarArchivo(archivo);
                });

                lstLog.Items.Add("Sincronización activada");

                settings.sincronizacion = true;
                ActualizarEstadoUI(true);

                MessageBox.Show("Se ha iniciado la sincronización.");
            }
            catch (Exception ex)
            {
                Bitacora.RegistrarError($"Error al iniciar la sincronización: {ex.Message}");
                MessageBox.Show(ex.Message, "Ha ocurrido un error modificando la configuración, intente de nuevo");
            }
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            try
            {
                settings.sincronizacion = false;
                lstLog.Items.Add("Sincronización pausada");
                MessageBox.Show("La sincronización ha sido pausada.");

                ActualizarEstadoUI(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido un error al pausar la sincronización, intente de nuevo");
            }
        }

        private void btnReanudar_Click(object sender, EventArgs e)
        {
            try
            {
                settings.sincronizacion = true;
                sincronizador.Resincronizacion();
                lstLog.Items.Add("Sincronización reanudada");
                MessageBox.Show("La sincronización ha sido reanudada.");

                ActualizarEstadoUI(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido un error al reanudar la sincronización, intente de nuevo");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
