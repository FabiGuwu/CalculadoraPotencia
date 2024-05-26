using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Convertidor.Reglas_del_negocio;

namespace Convertidor
{
    public partial class frmPotencia : Form
    {
        public frmPotencia()
        {
            InitializeComponent();
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumero.Text, out double baseValue) && int.TryParse(txtElevar.Text, out int potenciaValue))
            {
                if (potenciaValue <= 10)
                {
                    double resultado = Class1.Calcular(baseValue, potenciaValue);
                    lblResultado.Text = $"Resultado: {resultado}";
                }
                else
                {
                    MessageBox.Show("La potencia no puede ser mayor a 10.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese números válidos en los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
