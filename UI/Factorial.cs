using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjerciciosLibro.BLL;

namespace EjerciciosLibro.UI
{
    public partial class Factorial : Form
    {
        public Factorial()
        {
            InitializeComponent();
        }

        private void Calcularbutton_Click(object sender, EventArgs e)
        {
            FactorialBLL F = new FactorialBLL();
            int num = Convert.ToInt32(NumerotextBox1.Text);
            ResultadotextBox.Text = Convert.ToString(F.FunFactorial(num));
        }
    }
}
