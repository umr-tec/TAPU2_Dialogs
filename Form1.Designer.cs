
namespace TAPU2_Dialogs
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbImagenCargada = new System.Windows.Forms.PictureBox();
            this.bntImagen = new System.Windows.Forms.Button();
            this.ofdCargarImagen = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenCargada)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImagenCargada
            // 
            this.pbImagenCargada.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbImagenCargada.Location = new System.Drawing.Point(0, 0);
            this.pbImagenCargada.Name = "pbImagenCargada";
            this.pbImagenCargada.Size = new System.Drawing.Size(490, 342);
            this.pbImagenCargada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagenCargada.TabIndex = 0;
            this.pbImagenCargada.TabStop = false;
            // 
            // bntImagen
            // 
            this.bntImagen.BackgroundImage = global::TAPU2_Dialogs.Properties.Resources.camera;
            this.bntImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bntImagen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bntImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntImagen.Font = new System.Drawing.Font("IBM Plex Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntImagen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntImagen.Location = new System.Drawing.Point(0, 348);
            this.bntImagen.Name = "bntImagen";
            this.bntImagen.Size = new System.Drawing.Size(490, 53);
            this.bntImagen.TabIndex = 1;
            this.bntImagen.Text = "Cargar";
            this.bntImagen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntImagen.UseVisualStyleBackColor = true;
            this.bntImagen.Click += new System.EventHandler(this.bntImagen_Click);
            // 
            // ofdCargarImagen
            // 
            this.ofdCargarImagen.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(490, 401);
            this.Controls.Add(this.bntImagen);
            this.Controls.Add(this.pbImagenCargada);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenFileDialog";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenCargada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagenCargada;
        private System.Windows.Forms.Button bntImagen;
        private System.Windows.Forms.OpenFileDialog ofdCargarImagen;
    }
}

