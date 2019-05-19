using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjerciciosLibro.UI;

namespace EjerciciosLibro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ejercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factorial F = new Factorial();
            F.Visible = true;
        }

        private void Ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Diccionario D = new Diccionario();
            D.Visible = true;
        }

        private void Ejercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contactos c = new Contactos();
            c.Visible = true;
        }

        private void EjercicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hora h = new Hora();
            h.Visible = true;
        }

        private void Ejercicio5ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cadenas c = new Cadenas();
            c.Visible = true;
        }
    }
}
