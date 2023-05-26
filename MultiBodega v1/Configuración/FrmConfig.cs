using MultiBodega_v1.Botonera;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiBodega_v1.Configuración
{
    public partial class FrmConfig : Form
    {
        public FrmConfig()
        {
            InitializeComponent();
            treeView1.ExpandAll();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Botonera_APP Volver = new Botonera_APP();
            Volver.Show();
        }

        private void Ck_Marcar_Todos_CheckedChanged(object sender, EventArgs e)
        {
            bool checkState = Ck_Marcar_Todos.Checked;
            MarcarDesmarcarCheckBoxs(treeView1.Nodes, checkState);
        }

        private void MarcarDesmarcarCheckBoxs(TreeNodeCollection nodes, bool checkState)
        {
            foreach (TreeNode node in nodes)
            {
                node.Checked = checkState;
                MarcarDesmarcarCheckBoxs(node.Nodes, checkState);
            }
        }
    }
}
