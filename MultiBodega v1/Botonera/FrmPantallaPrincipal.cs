﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiBodega_v1.Botonera
{
    public partial class FrmPantallaPrincipal : Form
    {
        public FrmPantallaPrincipal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;

        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            var Botonera = new Botonera_APP();
            Botonera.Show();
        }
    }
}
