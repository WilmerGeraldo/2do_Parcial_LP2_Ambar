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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            frmEmpleados empleados = new frmEmpleados();
            this.Hide();
            empleados.Show();
        }

        private void btnNomina_Click(object sender, EventArgs e)
        {
            frmNomina nomina = new frmNomina();
            this.Hide();
            nomina.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
