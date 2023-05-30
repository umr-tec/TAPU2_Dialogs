
namespace TAPU2_Dialogs
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            this.btnFoto = new System.Windows.Forms.Button();
            this.btnVideo = new System.Windows.Forms.Button();
            this.gbOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOpciones
            // 
            this.gbOpciones.Controls.Add(this.btnImprimir);
            this.gbOpciones.Controls.Add(this.btnDetener);
            this.gbOpciones.Controls.Add(this.btnFoto);
            this.gbOpciones.Controls.Add(this.btnVideo);
            this.gbOpciones.Controls.Add(this.label1);
            this.gbOpciones.Controls.Add(this.comboBox1);
            this.gbOpciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbOpciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbOpciones.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpciones.Location = new System.Drawing.Point(0, 0);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(887, 161);
            this.gbOpciones.TabIndex = 0;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Opciones";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(265, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(610, 27);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dispositivos de video disponibles:";
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackgroundImage = global::TAPU2_Dialogs.Properties.Resources.print_FILL0_wght400_GRAD0_opsz48;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Location = new System.Drawing.Point(774, 56);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(101, 99);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnDetener
            // 
            this.btnDetener.BackgroundImage = global::TAPU2_Dialogs.Properties.Resources.stop_circle_FILL0_wght400_GRAD0_opsz48;
            this.btnDetener.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDetener.FlatAppearance.BorderSize = 0;
            this.btnDetener.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetener.Location = new System.Drawing.Point(560, 56);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(101, 99);
            this.btnDetener.TabIndex = 3;
            this.btnDetener.Text = "Detener";
            this.btnDetener.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDetener.UseVisualStyleBackColor = true;
            // 
            // btnFoto
            // 
            this.btnFoto.BackgroundImage = global::TAPU2_Dialogs.Properties.Resources.photo_camera_FILL0_wght400_GRAD0_opsz48;
            this.btnFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFoto.FlatAppearance.BorderSize = 0;
            this.btnFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoto.Location = new System.Drawing.Point(667, 56);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(101, 99);
            this.btnFoto.TabIndex = 3;
            this.btnFoto.Text = "Foto";
            this.btnFoto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFoto.UseVisualStyleBackColor = true;
            // 
            // btnVideo
            // 
            this.btnVideo.BackgroundImage = global::TAPU2_Dialogs.Properties.Resources.play_circle_FILL0_wght400_GRAD0_opsz48;
            this.btnVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVideo.FlatAppearance.BorderSize = 0;
            this.btnVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVideo.Location = new System.Drawing.Point(453, 56);
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.Size = new System.Drawing.Size(101, 99);
            this.btnVideo.TabIndex = 2;
            this.btnVideo.Text = "Iniciar";
            this.btnVideo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVideo.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(887, 635);
            this.Controls.Add(this.gbOpciones);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dialogos";
            this.gbOpciones.ResumeLayout(false);
            this.gbOpciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOpciones;
        private System.Windows.Forms.Button btnVideo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Button btnImprimir;
    }
}