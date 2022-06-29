using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularArea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            double n1 = 0;
            double n2 = 0;
            double resultado = 0;
            if (txtAltura2.Text != "" && txtBase1.Text != "")
            {
                n1 = double.Parse(txtAltura2.Text);
                n2 = double.Parse(txtBase1.Text);
                resultado = (double)n1 * (double)n2 / 2;
                lblResultado.Text = resultado.ToString();
            }
               

        }
        
    }
}
