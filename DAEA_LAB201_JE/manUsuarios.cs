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
    public partial class manUsuarios : Form
    {
        public manUsuarios()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text;
            string nom = txtNombre.Text;
            string ape = txtApellido.Text;
            string tel = txtTelefono.Text;
            string ema = txtEmail.Text;
            string fec = txtFecNac.Text;
            String dir = txtDireccion.Text;

            dgvUsuarios.Rows.Add(dni, nom, ape, tel, fec, ema, dir);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void manUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
