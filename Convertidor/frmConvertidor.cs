using System.Security.Cryptography;

namespace Convertidor
{
    public partial class frmConvertidor : Form
    {
        public frmConvertidor()
        {
            InitializeComponent();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void potenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Potencia = new frmPotencia();
            Potencia.Show();
        }
    }
}
