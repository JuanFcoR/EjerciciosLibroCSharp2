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
using System.Collections;

namespace EjerciciosLibro.UI
{
    public partial class Contactos : Form
    {
        Hashtable contactos = new Hashtable();
        public Contactos()
        {
            InitializeComponent();
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            ContactosListBox.Items.Clear();

            AgendaBLL.insertar(contactos, Convert.ToString(NombreTextBox.Text), Convert.ToString(NumeroMaskedTextBox.Text));

            foreach (DictionaryEntry datos in contactos)
            {
                ContactosListBox.Items.Add("Nombre: " + datos.Key + "  Telefno: " + datos.Value);
            }
        }
    }
}
