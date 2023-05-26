﻿using MultiBodega_v1.Botonera;
using MultiBodega_v1.Formularios_de_Registro;
using MultiBodega_v1.Listar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiBodega_v1.Registro
{
    public partial class FrmRegistrar : Form
    {
        public FrmRegistrar()
        {
            InitializeComponent();
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmListar nuevoform = new FrmListar();
            nuevoform.Show();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Botonera_APP Volver = new Botonera_APP();
            Volver.Show();
        }

        private void BtnRP_Click(object sender, EventArgs e)
        {
            this.Close();
            var nuevoproveedor = new FrmRegistrarProveedores();
            nuevoproveedor.Show();
        }

        private void BtnRT_Click(object sender, EventArgs e)
        {
            this.Close();
            var nuevotec = new FrmRegistrarTecnico();
            nuevotec.Show();
        }

        private void BtnRBF_Click(object sender, EventArgs e)
        {
            this.Close();
            var nuevoBasef = new FrmRegistrarBaseForanea();
            nuevoBasef.Show();
        }

        private void BtnRPV_Click(object sender, EventArgs e)
        {
            this.Close();
            var nuevoPV = new FrmRegistrarPuntodeVenta();
            nuevoPV.Show();
        }
    }
}