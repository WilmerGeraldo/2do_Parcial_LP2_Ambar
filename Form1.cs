using _2do_Parcial_LP2.Forms;

namespace _2do_Parcial_LP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pbar.Value = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void Tiempo_Carga()
        {
            pbar.Value += 4;
            pbar.Text = pbar.Value.ToString() + "%";
            if (pbar.Value == 100)
            {
                timer1.Enabled = false;
                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Tiempo_Carga();
        }
    }
}
