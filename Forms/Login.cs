using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2do_Parcial_LP2.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtClave.Text == "1826" && cboUsuario.Text == "Wilson" || txtClave.Text == "" && cboUsuario.Text == "Dilone")
            {
                MessageBox.Show("Hola");
                Home home = new Home();
                home.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("usuario o clave incorrecta");
            }
        }
    }
}
