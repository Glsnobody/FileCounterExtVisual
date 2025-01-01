using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FileCounterExtVisual
{
    public partial class FileCounterExtVisualWindow : Form
    {
        public FileCounterExtVisualWindow()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string ruta = folderDialog.SelectedPath;
                    txtRuta.Text = ruta;
                    ProcesarArchivosPorCarpeta(ruta);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ProcesarArchivosPorCarpeta(string ruta)
        {
            if (Directory.Exists(ruta))
            {
                txtResultados.Clear();

                // Obtener el filtro seleccionado
                string filtro = cmbFiltro.SelectedItem?.ToString() ?? string.Empty;
                string[] archivosDirectos;

                // Si el filtro está vacío, procesar todos los archivos como en tu implementación original
                if (string.IsNullOrEmpty(filtro))
                {
                    archivosDirectos = Directory.GetFiles(ruta, "*.*", SearchOption.TopDirectoryOnly);
                }
                else
                {
                    // Si hay filtro, procesar solo los archivos que coincidan con la extensión seleccionada
                    archivosDirectos = Directory.GetFiles(ruta, $"*{filtro}", SearchOption.TopDirectoryOnly);
                }

                // Mostrar solo si hay archivos en el directorio principal
                if (archivosDirectos.Length > 0)
                {
                    txtResultados.AppendText($"[Directorio Principal]{Environment.NewLine}");
                    MostrarExtensionesYConteo(archivosDirectos);
                }

                // Obtener todas las subcarpetas del directorio seleccionado
                string[] subcarpetas = Directory.GetDirectories(ruta);

                // Si no hay subcarpetas, muestra un mensaje
                if (subcarpetas.Length == 0)
                {
                    txtResultados.AppendText("No se encontraron subcarpetas en el directorio.\n");
                }

                // Procesar cada subcarpeta
                foreach (var subcarpeta in subcarpetas)
                {
                    string[] archivosEnSubcarpeta;
                    if (string.IsNullOrEmpty(filtro))
                    {
                        archivosEnSubcarpeta = Directory.GetFiles(subcarpeta, "*.*", SearchOption.AllDirectories);
                    }
                    else
                    {
                        archivosEnSubcarpeta = Directory.GetFiles(subcarpeta, $"*{filtro}", SearchOption.AllDirectories);
                    }
                    txtResultados.AppendText($"\n📁[Carpeta: {Path.GetFileName(subcarpeta)}]{Environment.NewLine}");
                    MostrarExtensionesYConteo(archivosEnSubcarpeta);
                }

                lblCantidadArchivos.Text = $"Cantidad total de archivos: {archivosDirectos.Length + subcarpetas.Sum(c => Directory.GetFiles(c, $"*{filtro}", SearchOption.AllDirectories).Length)}";
            }
            else
            {
                MessageBox.Show("La ruta especificada no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filtro = cmbFiltro.Text?.Trim().ToLower();  // Obtener lo que el usuario escribe

            // Si el filtro no comienza con un punto, agregarlo
            if (!string.IsNullOrEmpty(filtro) && !filtro.StartsWith("."))
            {
                filtro = "." + filtro;  // Convertir "jpg" en ".jpg"
            }

            string ruta = txtRuta.Text;  // Asumiendo que la ruta ya está seleccionada
            ProcesarArchivosPorCarpeta(ruta);  // Llamamos a la función sin modificarla
        }




        private void MostrarExtensionesYConteo(string[] archivos)
        {
            if (archivos.Length == 0)
            {
                txtResultados.AppendText("No se encontraron archivos en esta carpeta.\n");
                return;
            }

            // Agrupar archivos por extensión
            var agrupadosPorExtension = archivos
                .GroupBy(archivo => Path.GetExtension(archivo).ToLower())
                .OrderBy(grupo => grupo.Key);

            foreach (var grupo in agrupadosPorExtension)
            {
                string extension = string.IsNullOrEmpty(grupo.Key) ? "Sin extensión" : grupo.Key;
                txtResultados.AppendText($"    {extension}: {grupo.Count()}{Environment.NewLine}");
            }
        }
    }
}
