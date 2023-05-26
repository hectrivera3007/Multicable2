using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace MultiBodega_v1
{
    public partial class LoginBodega : Form
    {
        
        public LoginBodega()
        {
            InitializeComponent();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var NuevoUsuario = new FrmUsuarios()
            {
                
            };
            NuevoUsuario.Show();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox4.PasswordChar = '\0';
            }
            else
            {
                textBox4.PasswordChar = '●';
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            string usuario = textBox2.Text;
            string passwd = textBox4.Text;
            



            if (usuario == "Héctor" && passwd == "1234")
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe digitar datos correctos para iniciar sesión.");
                textBox2.Focus();
            }
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) && !string.IsNullOrEmpty(textBox2.Text))
            {
                textBox4.Focus();
            }
        }

        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) && !string.IsNullOrEmpty(textBox2.Text))
            {
                button2.PerformClick();

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
