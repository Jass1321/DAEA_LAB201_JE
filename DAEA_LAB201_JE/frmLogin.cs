using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAEA_LAB201_JE
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.TextLength > 6)
            {
                if (txtPassword.TextLength > 6)
                {
                    string user = txtUsuario.Text;
                    string pass = txtPassword.Text;

                    List<string> usuarioLists = new List<string>();

                    usuarioLists.Add("Usuario: " + user + "  Contraseña: " + pass);
                    Console.WriteLine();
                    foreach (string usuarioList in usuarioLists)
                    {
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine(usuarioList);
                        Console.WriteLine("--------------------------------------");
                    }

                    principalMDI principal = new principalMDI();
                    principal.Show();
                    this.Hide();
                }
                else msgError("La contraseña mayor a 6 digitos.");
            }
            else msgError("El usuario mayor a 6 digitos.");

        }
        private void msgError(string msg)
        {
            lblErrorMessage.Text = "    " + msg;
            lblErrorMessage.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
