namespace FileCounterExtVisual
{
    partial class Form1
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
            txtRuta = new TextBox();
            btnBrowse = new Button();
            lblCantidadArchivos = new Label();
            txtResultados = new TextBox();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // txtRuta
            // 
            txtRuta.Location = new Point(13, 61);
            txtRuta.Margin = new Padding(4);
            txtRuta.Name = "txtRuta";
            txtRuta.ReadOnly = true;
            txtRuta.Size = new Size(411, 34);
            txtRuta.TabIndex = 0;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(431, 59);
            btnBrowse.Margin = new Padding(4);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(170, 38);
            btnBrowse.TabIndex = 1;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // lblCantidadArchivos
            // 
            lblCantidadArchivos.AutoSize = true;
            lblCantidadArchivos.Location = new Point(13, 108);
            lblCantidadArchivos.Margin = new Padding(4, 0, 4, 0);
            lblCantidadArchivos.Name = "lblCantidadArchivos";
            lblCantidadArchivos.Size = new Size(261, 28);
            lblCantidadArchivos.TabIndex = 2;
            lblCantidadArchivos.Text = "Cantidad total de archivos: 0";
            // 
            // txtResultados
            // 
            txtResultados.Location = new Point(13, 152);
            txtResultados.Margin = new Padding(4);
            txtResultados.Multiline = true;
            txtResultados.Name = "txtResultados";
            txtResultados.ReadOnly = true;
            txtResultados.ScrollBars = ScrollBars.Vertical;
            txtResultados.Size = new Size(588, 261);
            txtResultados.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(13, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(135, 28);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Elige una ruta:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(614, 426);
            Controls.Add(lblTitle);
            Controls.Add(txtResultados);
            Controls.Add(lblCantidadArchivos);
            Controls.Add(btnBrowse);
            Controls.Add(txtRuta);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "FileCounterExt 1.0";
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
    }
}
