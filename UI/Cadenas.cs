using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosLibro.UI
{
    public partial class Cadenas : Form
    {
        public Cadenas()
        {
            InitializeComponent();
        }

        private void OrdenButton_Click(object sender, EventArgs e)
        {
            string cad1, cad2;
            cad1 = Cad1RichTextBox.Text.ToString();
            cad2 = Cad2RichTextBox.Text.ToString();
            OrdenListBox.Items.Clear();
            if(String.Compare(cad1,cad2)==0)
            {
                MessageBox.Show("Ambas Cadenas son igualos","OOPs",MessageBoxButtons.OK);
            }
            else
            {
                if (String.Compare(cad1, cad2) > 0)
                {
                    OrdenListBox.Items.Add(cad1);
                    OrdenListBox.Items.Add(cad2);
                }
                else
                {
                    OrdenListBox.Items.Add(cad2);
                    OrdenListBox.Items.Add(cad1);
                }
                    

            }
        }
    }
}
