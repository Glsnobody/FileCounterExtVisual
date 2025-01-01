namespace FileCounterExtVisual
{
    public partial class Form1 : Form
    {
        public Form1()
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
                    ProcesarArchivos(ruta);
                }
            }
        }

        private void ProcesarArchivos(string ruta)
        {
            if (Directory.Exists(ruta))
            {
                // Obtener todos los archivos en la ruta
                string[] archivos = Directory.GetFiles(ruta, "*.*", SearchOption.TopDirectoryOnly);

                lblCantidadArchivos.Text = $"Cantidad total de archivos: {archivos.Length}";

                // Agrupar archivos por extensión
                var agrupadosPorExtension = archivos
                    .GroupBy(archivo => Path.GetExtension(archivo).ToLower())
                    .OrderBy(grupo => grupo.Key);

                // Mostrar extensiones y cantidades en el TextBox
                txtResultados.Clear();
                foreach (var grupo in agrupadosPorExtension)
                {
                    string extension = string.IsNullOrEmpty(grupo.Key) ? "Sin extensión" : grupo.Key;
                    txtResultados.AppendText($"{extension}: {grupo.Count()}{Environment.NewLine}");
                }
            }
            else
            {
                MessageBox.Show("La ruta especificada no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
