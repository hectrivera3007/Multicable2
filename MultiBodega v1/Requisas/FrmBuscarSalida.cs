﻿using MultiBodega_v1.Botonera.Requisas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiBodega_v1.Requisas
{
    public partial class FrmBuscarSalida : Form
    {
        public FrmBuscarSalida()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            var Volver = new Botonera_Requisas();
            Volver.Show();
        }
    }
}
