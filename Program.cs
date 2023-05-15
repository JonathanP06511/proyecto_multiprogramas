using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtNum1.Text);
            double num2 = double.Parse(txtNum2.Text);

            lblSuma.Text = (num1 + num2).ToString();
            lblResta.Text = (num1 - num2).ToString();
            lblMultiplicacion.Text = (num1 * num2).ToString();
            lblDivision.Text = (num1 / num2).ToString();
        }
    }
}
