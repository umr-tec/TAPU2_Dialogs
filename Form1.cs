﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAPU2_Dialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void bntImagen_Click(object sender, EventArgs e)
        {
            //Programar el control OpenFileDialog
            DialogResult result = ofdCargarImagen.ShowDialog();
            
            
            if (result == DialogResult.OK)
            {
                string archivo = ofdCargarImagen.FileName;
                pbImagenCargada.ImageLocation = archivo;
            }
        }
    }
}
