﻿namespace FileCounterExtVisual
{
    partial class FileCounterExtVisualWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileCounterExtVisualWindow));
            txtRuta = new TextBox();
            btnBrowse = new Button();
            lblCantidadArchivos = new Label();
            txtResultados = new TextBox();
            lblTitle = new Label();
            label1 = new Label();
            cmbFiltro = new ComboBox();
            SuspendLayout();
            // 
            // txtRuta
            // 
            txtRuta.Location = new Point(13, 111);
            txtRuta.Margin = new Padding(4);
            txtRuta.Name = "txtRuta";
            txtRuta.ReadOnly = true;
            txtRuta.Size = new Size(435, 34);
            txtRuta.TabIndex = 0;
            // 
            // btnBrowse
            // 
            btnBrowse.BackgroundImage = (Image)resources.GetObject("btnBrowse.BackgroundImage");
            btnBrowse.BackgroundImageLayout = ImageLayout.Stretch;
            btnBrowse.Location = new Point(456, 111);
            btnBrowse.Margin = new Padding(4);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(34, 34);
            btnBrowse.TabIndex = 1;
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // lblCantidadArchivos
            // 
            lblCantidadArchivos.AutoSize = true;
            lblCantidadArchivos.Location = new Point(13, 154);
            lblCantidadArchivos.Margin = new Padding(4, 0, 4, 0);
            lblCantidadArchivos.Name = "lblCantidadArchivos";
            lblCantidadArchivos.Size = new Size(261, 28);
            lblCantidadArchivos.TabIndex = 2;
            lblCantidadArchivos.Text = "Cantidad total de archivos: 0";
            // 
            // txtResultados
            // 
            txtResultados.Location = new Point(13, 192);
            txtResultados.Margin = new Padding(4);
            txtResultados.Multiline = true;
            txtResultados.Name = "txtResultados";
            txtResultados.ReadOnly = true;
            txtResultados.ScrollBars = ScrollBars.Vertical;
            txtResultados.Size = new Size(473, 450);
            txtResultados.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(12, 70);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(135, 28);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Elige una ruta:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 19);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(99, 28);
            label1.TabIndex = 5;
            label1.Text = "Extensión:";
            // 
            // cmbFiltro
            // 
            cmbFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltro.FormattingEnabled = true;
            cmbFiltro.Items.AddRange(new object[] { "", "3ds", "3gp", "7z", "accdb", "ace", "ai", "ai", "apk", "app", "avi", "avi", "azw3", "bak", "bat", "bin", "blender", "bmp", "bzip2", "cab", "conf", "cpp", "crm", "css", "csv", "dat", "dat", "db", "dll", "dmg", "dmg", "doc", "docx", "emf", "eml", "eps", "eps", "epub", "exe", "exr", "fbx", "flac", "flv", "flv", "gif", "go", "gz", "heic", "heic", "heif", "heif", "heif", "html", "ico", "ics", "indd", "ini", "iso", "jar", "jar", "jfif", "jpg", "jpeg", "js", "json", "lua", "m4a", "m4b", "m4v", "md", "md5", "midi", "mkv", "mob", "mov", "mp3", "mp4", "mpc", "mpeg", "mpg", "msi", "n64", "nif", "obj", "odt", "otf", "pcx", "pdb", "pdf", "pdfx", "php", "ply", "png", "ppt", "pptx", "ps", "psd", "psd", "pub", "py", "rar", "raw", "rb", "rle", "rm", "rmvb", "rtf", "sav", "sfv", "sh", "sqlite", "stl", "svg", "swf", "sys", "tar", "tar.bz2", "tar.gz", "tga", "tiff", "torrent", "ttf", "txt", "vhd", "vmdk", "vob", "webm", "webp", "wma", "wmv", "wv", "xls", "xlsx", "xml", "xpi", "xz", "yaml", "zip", "zsh" });
            cmbFiltro.Location = new Point(118, 19);
            cmbFiltro.Name = "cmbFiltro";
            cmbFiltro.Size = new Size(368, 36);
            cmbFiltro.TabIndex = 7;
            // 
            // FileCounterExtVisualWindow
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(499, 655);
            Controls.Add(cmbFiltro);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(txtResultados);
            Controls.Add(lblCantidadArchivos);
            Controls.Add(btnBrowse);
            Controls.Add(txtRuta);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FileCounterExtVisualWindow";
            Text = "FileCounterExt 1.1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRuta;
        private Button btnBrowse;
        private Label lblCantidadArchivos;
        private TextBox txtResultados;
        private Label lblTitle;
        private Label label1;
        private ComboBox cmbFiltro;
    }
}
