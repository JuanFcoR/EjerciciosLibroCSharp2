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
    public partial class Hora : Form
    {
        public Hora()
        {
            InitializeComponent();
        }

        private void HoraButton_Click(object sender, EventArgs e)
        {
            string letras;
            DateTime horaRec = Convert.ToDateTime(HoraDateTimePicker.Value);

            HoraTextBox.Text = HoraBll.hora(horaRec);
        }
    }
}
