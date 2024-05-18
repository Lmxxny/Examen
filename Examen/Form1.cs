using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string user;
            string pass;

            if (string.IsNullOrEmpty(txtusser.Text) || string.IsNullOrEmpty(txtpass.Text))
            {
                MessageBox.Show("Por favor, ingresa un valor en los campos en blanco", "Dato faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                user = Convert.ToString(txtusser.Text);
                pass = Convert.ToString(txtpass.Text);

                if (user == "lmxxny" && pass == "pass1234")
                {
                    Form2 ir = new Form2();
                    ir.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario inválido", "Usuario Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
